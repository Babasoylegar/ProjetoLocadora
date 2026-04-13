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
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
            DesativarCampos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            AtivarCampos();
        }
        private void DesativarCampos()
        {
            txtcodigo.Enabled = false;
            txtnome.Enabled = false;
            txtendereco.Enabled = false;
            mskcpf.Enabled = false;
            cbbprofissao.Enabled = false;
        }
        private void AtivarCampos()
        {
            txtcodigo.Enabled = true;
            txtnome.Enabled = true;
            txtendereco.Enabled = true;
            mskcpf.Enabled = true;
            cbbprofissao.Enabled = true;
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtendereco.Clear();
            mskcpf.Clear();
            cbbprofissao.Items.Clear();
        }
    }
}
