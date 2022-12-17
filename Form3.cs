using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void manutençãoFrotaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formAdicionar principal = new formAdicionar();
            frmAdicionar principal = new frmAdicionar();
            principal.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void consultarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
