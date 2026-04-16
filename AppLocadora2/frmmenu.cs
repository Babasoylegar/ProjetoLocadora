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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            frmcliente frmcliente = new frmcliente();
            frmcliente.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnreserva_Click(object sender, EventArgs e)
        {
            frmreserva frmreserva = new frmreserva();
            frmreserva.Show();
            this.Hide();
        }

        private void btnveiculo_Click(object sender, EventArgs e)
        {
            frmveiculo frmveiculo = new frmveiculo();
            frmveiculo.Show();
            this.Hide();
        }
    }
}
