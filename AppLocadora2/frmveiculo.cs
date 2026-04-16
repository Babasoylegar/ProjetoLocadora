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
    public partial class frmveiculo : Form
    {
        public frmveiculo()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            ListBoxveiculo.Items.Add(string.Format("{0}", txtnome.Text));
            MessageBox.Show("Item adicionado com sucesso");
        }

        private void btnremover_Click(object sender, EventArgs e)
        {
            // Verifica se existe algum item selecionado (índice 0 ou maior)
            if (ListBoxveiculo.SelectedIndex != -1)
            {
                ListBoxveiculo.Items.RemoveAt(ListBoxveiculo.SelectedIndex);
                MessageBox.Show("Item removido com sucesso!");
            }
            else
            {
                // Caso o usuário não tenha clicado em nada na lista
                MessageBox.Show("Por favor, selecione um item na lista para remover.", "Aviso");
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnome.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Hide();
        }
    }
}
