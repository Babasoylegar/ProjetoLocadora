using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLocadora2
{
    public partial class frmdiaria : Form
    {
        public frmdiaria()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void frmdiaria_Load(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }
        private void DesabilitarCampos()
        {
            txtcodigo.Enabled = false;
            txtdata.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtcodigo.Enabled = true;
            txtdata.Enabled = true;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtdata.Clear();
            txtcodigo.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
