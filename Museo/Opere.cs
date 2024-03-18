using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    internal static class Opere
    {
        private static int index = -1;
        private static string file_path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\museo.dat";

        private static FileStream fs;
        private static BinaryReader br;
        private static BinaryWriter bw;

        public static void Init()
        {
            FileStream open = new FileStream(file_path, FileMode.Append, FileAccess.Write);
            open.Close();

            fs = new FileStream(file_path, FileMode.Open, FileAccess.ReadWrite);
            br = new BinaryReader(fs);
            bw = new BinaryWriter(fs);
        }

        public static List<string> GetOpere()
        {
            List<string> opere = new List<string>();

            fs.Seek(0, SeekOrigin.Begin);

            while (br.PeekChar() != -1)
            {
                Opera o = new Opera();
                int id = br.ReadInt32();
                o.ID = id;
                o.Autore = br.ReadString().TrimEnd();
                o.Titolo = br.ReadString().TrimEnd();
                o.Anno = br.ReadInt32();
                o.Tipologia = (TipologiaOpera)br.ReadInt32();

                if (id != -1)
                    opere.Add(o.ToString());
            }

            return opere;
        }

        public static void Aggiungi(string autore, string titolo, int anno, TipologiaOpera tipologia)
        {
            Opera o = new Opera(0, autore, titolo, anno, tipologia);

            TrovaID(-1);
            o.ID = index++;

            bw.Write(o.ID);
            bw.Write(o.Autore.PadRight(50, ' '));
            bw.Write(o.Titolo.PadRight(50, ' '));
            bw.Write(o.Anno);
            bw.Write((int)o.Tipologia);
        }

        public static void Modifica(int id, string autore, string titolo, int anno, TipologiaOpera tipologia)
        {
            Opera o = new Opera(0, autore, titolo, anno, tipologia);

            TrovaID(id);
            o.ID = index++;

            bw.Write(o.ID);
            bw.Write(o.Autore.PadRight(50, ' '));
            bw.Write(o.Titolo.PadRight(50, ' '));
            bw.Write(o.Anno);
            bw.Write((int)o.Tipologia);
        }

        public static void Elimina(int id)
        {
            TrovaID(id);
            bw.Write(-1);
        }

        public static string Cerca(string autore)
        {
            if (!TrovaAutore(autore))
            {
                return null;
            }
            Opera o = new Opera();
            o.ID = br.ReadInt32();
            o.Autore = br.ReadString().TrimEnd();
            o.Titolo = br.ReadString().TrimEnd();
            o.Anno = br.ReadInt32();
            o.Tipologia = (TipologiaOpera)br.ReadInt32();

            return o.ToString();
        }

        public static string AttributiFile()
        {
            string strInfo = "";
            DateTime dt;

            FileInfo fi = new FileInfo(file_path);
            
            strInfo = "File: " + file_path;
            strInfo += "\nDim: " + (fi.Length) + " Byte, " + (fi.Length / 1024) + " KB, " +
                (float)(fi.Length / 1024 / 1024) + " MB";
            dt = fi.CreationTime;
            strInfo += "\nData di creazione: " + dt.ToString();
            dt = fi.LastAccessTime;
            strInfo += "\nData ultimo accesso: " + dt.ToString();

            return strInfo;
        }

        public static void AggiornaIndice()
        {
            TrovaID(-2);
        }

        private static void TrovaID(int ID)
        {
            bool qui = false;
            long pos;
            index = 0;

            fs.Seek(0, SeekOrigin.Begin);

            while (br.PeekChar() != -1 && !qui)
            {
                pos = fs.Position;
                int tempInt;
                string tempStr;
                int id = br.ReadInt32();
                tempStr = br.ReadString().TrimEnd();
                tempStr = br.ReadString().TrimEnd();
                tempInt = br.ReadInt32();
                tempInt = br.ReadInt32();

                index++;

                if (id == ID)
                {
                    fs.Seek(pos, SeekOrigin.Begin);
                    index--;
                    qui = true;
                }
            }
        }

        private static bool TrovaAutore(string Titolo)
        {
            bool qui = false;
            long pos;
            index = 0;

            fs.Seek(0, SeekOrigin.Begin);

            while (br.PeekChar() != -1 && !qui)
            {
                pos = fs.Position;
                int tempInt;
                string tempStr;
                tempInt = br.ReadInt32();
                string autore = br.ReadString().TrimEnd();
                tempStr = br.ReadString().TrimEnd();
                tempInt = br.ReadInt32();
                tempInt = br.ReadInt32();

                index++;

                if (autore == Titolo)
                {
                    fs.Seek(pos, SeekOrigin.Begin);
                    index--;
                    qui = true;
                }
            }
            return qui;
        }

        public static int ID { get => index; }
    }
}
