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
    internal partial class frmMuseo : Form
    {

        // TODO:
        // Menù secondari per inserimento e modifica
        // Integrazione con file binario

        #region EVENTI

        public frmMuseo()
        {
            Opere.Init();
            InitializeComponent();
        }

        private void frmMuseo_Load(object sender, EventArgs e)
        {
            UpdateIndexes();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            AggiungiOpera();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            ModificaOpera(cmbModifica.SelectedIndex);
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            Opere.Elimina(cmbElimina.SelectedIndex);
        }

        private void btnVisualizza_Click(object sender, EventArgs e)
        {
            Visualizza(new Opera());
        }

        private void btnCerca_Click(object sender, EventArgs e)
        {
            frmCerca cerca = new frmCerca();
            DialogResult res = cerca.ShowDialog();
            if (res == DialogResult.OK)
            {
                Opere.Cerca(cerca.Autore);
                Visualizza(new Opera());
            }
        }
        
        private void btnInfoFile_Click(object sender, EventArgs e)
        {
            lblInfo.Text = Opere.AttributiFile();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res =
                MessageBox.Show(
                    "Sei sicuro di voler uscire?",
                    "Ti prego non farlo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
            );

            if ( res == DialogResult.Yes )
            {
                Application.Exit();
            }
        }

        #endregion

        #region METODI

        public void AggiungiOpera()
        {
            frmOpera aggiungi = new frmOpera(true, 0);
            aggiungi.ShowDialog();
            Visualizza(new Opera());
        }

        public void ModificaOpera(int id)
        {
            frmOpera modifica = new frmOpera(false, id);
            modifica.ShowDialog();
        }

        public void Visualizza(Opera opera)
        {
            grdData.Rows.Add(opera.ToString().Split('|'));
            UpdateIndexes();
        }

        public void UpdateIndexes()
        {
            cmbElimina.Items.Clear();
            cmbModifica.Items.Clear();
            for (int i = 0; i <= Opere.ID;  i++)
            {
                cmbElimina.Items.Add(i.ToString());
                cmbModifica.Items.Add(i.ToString());
            }
            if (Opere.ID >= 0)
            {
                cmbElimina.SelectedIndex = 0;
                cmbModifica.SelectedIndex = 0;
            }
        }

        #endregion

    }
}
