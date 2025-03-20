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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            CarregarRankingForm3();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CarregarRankingForm3();
        }

        private void CarregarRankingForm3()
        {
            dataGridView1.Rows.Clear();

            if (File.Exists("ranking.txt"))
            {
                var linhas = File.ReadAllLines("ranking.txt");

                foreach(var linha in linhas)
                {
                    var dados = linha.Split(';');
                    if(dados.Length == 5)
                    {
                        dataGridView1.Rows.Add(dados[0], dados[1], dados[2], dados[3], dados[4]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Não há nenhum ranking disponível");
            }
        }

        
    }
}
