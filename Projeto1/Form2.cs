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


        public void CarregarDadosDoJogador(string nomeDoJogador, string nivelDeDificuldade) //para deixar marcado o nome e a dificuldade escolhidos
        {
            EscreveNomedoJogador.Text = nomeDoJogador;
            EscreveNomedoJogador.SelectionStart = EscreveNomedoJogador.Text.Length;
            EscreveNomedoJogador.SelectionLength = 0; //para tirar a marcação do nome ao exibir o form2 em Dados do Usuário

            
            if(nivelDeDificuldade == "Fácil")
            {
                jogoModo_facil.Checked = true; //marca o raddiobutton do modo fácil
            }
            else
            {
                if(nivelDeDificuldade == "Difícil")
                {
                    jogoModo_dificil.Checked = true; //marca o raddiobutton do modo difícil
                }
            }
        }


        public string nomeDoJogador, nivelDeDificuldade;
        private void IniciarJogo_Click(object sender, EventArgs e)
        {
            nomeDoJogador = EscreveNomedoJogador.Text; //pega o nome do jogador da caixa de texto do formulário 2

            //para pegar o nível da dificuldade escolhido
            if (jogoModo_facil.Checked)
            {
                nivelDeDificuldade = "Fácil";
            }
            else
            {
                if (jogoModo_dificil.Checked)
                {
                    nivelDeDificuldade = "Difícil";
                }
            }

            Form1 form = new Form1(); //instancia para a chamada do formulário 1
            form.NomeDoJogador = nomeDoJogador; //para mostrar o nome do jogador no form 1
            form.NivelDeDificuldadeEscolhido = nivelDeDificuldade;
            form.Show(); //exibe o formulário 1

            //this.DialogResult = DialogResult.OK;
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
