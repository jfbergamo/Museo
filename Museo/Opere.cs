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
        private static int id = -1;
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
                o.ID = br.ReadInt32();
                o.Autore = br.ReadString().TrimEnd();
                o.Titolo = br.ReadString().TrimEnd();
                o.Anno = br.ReadInt32();
                o.Tipologia = (TipologiaOpera)br.ReadInt32();

                opere.Add(o.ToString());
            }

            return opere;
        }

        public static void Aggiungi(string autore, string titolo, int anno, TipologiaOpera tipologia)
        {
            Opera o = new Opera(++id, autore, titolo, anno, tipologia);
            bool qui = false;
            long pos;

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

                if (id == -1)
                {
                    fs.Seek(pos, SeekOrigin.Begin);
                    qui = true;
                }
            }

            bw.Write(o.ID);
            bw.Write(o.Autore.PadRight(50, ' '));
            bw.Write(o.Titolo.PadRight(50, ' '));
            bw.Write(o.Anno);
            bw.Write((int)o.Tipologia);
        }

        public static void Modifica(int id, string autore, string titolo, int anno, TipologiaOpera tipologia)
        {
            throw new NotImplementedException();
        }

        public static void Elimina(int id)
        {
            throw new NotImplementedException();
        }

        public static void Cerca(string autore)
        {
            throw new NotImplementedException();
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

        public static int ID { get => id; }
    }
}
