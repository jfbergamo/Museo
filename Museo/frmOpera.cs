using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Museo
{
    internal partial class frmOpera : Form
    {

        #region ATTRIBUTI

        private bool mode; // Se true aggiunge, se false modifica
        private int id;

        #endregion

        #region COSTRUTTORE

        public frmOpera(bool mode, int id)
        {
            this.mode = mode;
            this.id = id;
            InitializeComponent();
        }

        #endregion

        #region EVENTI

        private void frmAggiungi_Load(object sender, EventArgs e)
        {
            btnConferma.Text = mode ? "Aggiungi" : "Modifica";

            cmbTipo.Items.Clear();
            foreach (String tipo in Enum.GetNames(typeof(TipologiaOpera)))
            {
                cmbTipo.Items.Add(tipo);
            }
            cmbTipo.SelectedIndex = 0;
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            try
            {
                string titolo = txtTitolo.Text;
                string autore = txtAutore.Text;
                int anno = int.Parse(txtAnno.Text);
                TipologiaOpera tipo = (TipologiaOpera)cmbTipo.SelectedIndex;
                
                if (mode)
                {
                    Opere.Aggiungi(autore, titolo, anno, tipo);
                }
                else
                {
                    Opere.Modifica(id, autore, titolo, anno, tipo);
                }

                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Sono stati inseriti dei valori non validi!", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

    }
}
