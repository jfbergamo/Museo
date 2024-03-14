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
    public partial class frmMuseo : Form
    {
        public frmMuseo()
        {
            InitializeComponent();
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
    }
}
