using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void IniciarJogo_Click(object sender, EventArgs e)
        {
            string nomeDoJogador = EscreveNomedoJogador.Text; //pega o nome do jogador da caixa de texto do formulário 2

            Form1 form = new Form1();
            form.NomeDoJogador = nomeDoJogador;
            form.Show(); //exibe o formulário 1

            this.Hide(); //isso não fecha o formulário 2 mas o esconde
        }

        private void jogoModo_dificil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void jogoModo_facil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
