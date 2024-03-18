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
    public partial class frmCerca : Form
    {
        private string nome;

        public frmCerca()
        {
            InitializeComponent();
        }

        private void btnConferma_Click(object sender, EventArgs e)
        {
            nome = txtNome.Text;
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Inserisci un nome.", "ATTENZIONE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public string Autore { get => nome; }
    }
}
