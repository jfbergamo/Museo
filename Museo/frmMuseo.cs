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

        #region EVENTI

        public frmMuseo()
        {
            InitializeComponent();
        }

        private void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visualizza(new Opera());

            return;
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

        public void Visualizza(Opera opera)
        {
            grdData.Rows.Add(opera.ToString().Split('|'));
        }

        #endregion

    }
}
