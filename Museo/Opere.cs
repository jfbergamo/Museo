using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    internal static class Opere
    {
        private static int id = -1;

        public static void Aggiungi(string autore, string titolo, int anno, TipologiaOpera tipologia)
        {
            Opera gx = new Opera(++id, autore, titolo, anno, tipologia);
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

        public static int ID { get => id; }
    }
}
