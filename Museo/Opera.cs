using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Museo
{
    internal enum TipologiaOpera
    {
        QUADRO,
        SCULTURA,
        ARAZZO
    }

    internal class Opera
    {
        #region ATTRIBUTI

        private int id;
        private string autore;
        private string titolo;
        private int anno;
        private TipologiaOpera tipologia;

        #endregion

        #region COSTRUTTORI

        public Opera()
        {
            id = -1; // Valore invalido
            autore = "cescokevin"; // Valore a caso
            titolo = "colpa di cesco";
            anno = 0; // praticamente gesù
            tipologia = TipologiaOpera.ARAZZO; // perché sì
        }

        public Opera(int id, string autore, string titolo, int anno, TipologiaOpera tipologia)
        {
            ID = id;
            Autore = autore;
            Titolo = titolo;
            Anno = anno;
            Tipologia = tipologia;
        }

        #endregion

        #region METODI

        public override string ToString()
        {
            return ID.ToString() + "|" + Autore + "|" + Titolo + "|" + Anno.ToString() + "|" + Tipologia.ToString(); // TODO: implementarlo con proprietà
        }

        #endregion

        #region PROPRIETA'

        public int ID { get => id; set => id = Math.Abs(value); }
        public string Autore { get => autore; set => autore = value; }
        public string Titolo { get => titolo; set => titolo = value; }
        public int Anno { get => anno; set => anno = value; }
        public TipologiaOpera Tipologia { get => tipologia; set => tipologia = value; }

        #endregion

    }
}
