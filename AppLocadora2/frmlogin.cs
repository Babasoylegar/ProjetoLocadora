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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtsenha.Clear();
            txtusuario.Clear();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            string usuario = txtusuario.Text;
            bool sucesso = int.TryParse(txtsenha.Text, out int senha);

            if (sucesso && usuario == "admin" && senha == 123)
            {
                frmmenu frmmenu = new frmmenu();    
                frmmenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Dados incorretos!");
            }

        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            txtsenha.PasswordChar = '*';
        }
        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica se a tecla pressionada foi o Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Executa o clique do botão de login
                btnentrar.PerformClick();
            }
        }

    }
}
