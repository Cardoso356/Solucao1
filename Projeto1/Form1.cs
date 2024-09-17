using System.Collections.Specialized;

namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        int count2 = 0;
        bool JogoFinalizado = false; //lógica booleana para o controle do jogo
        private void juncaoDosBotoes_Click(object sender, EventArgs e)
        {
            if(JogoFinalizado)
            {
                return; //impede jogadas se o jogo estiver finalizado
            }
            if (((Button)sender).Text == "")
            {
                if (count == 0)
                {
                    ((Button)sender).Text = "X";
                    count++;
                    count2++;
                    Ganhador();

                    if(JogoFinalizado)
                    {
                        return;
                    }

                    if(count2 < 9) //o sistema faz suas jogadas se ainda tiver opções
                    {
                        JogadaDoComputador();
                    }
                }
                
            }

            //Ganhador();
            if (count2 == 9 && !JogoFinalizado)
            {
                Empate();
            }
            
        }

        private void JogadaDoComputador()
        {
            if (JogoFinalizado)
            {
                return;
            }

            List<Button> BotoesVazios = new List<Button>(); //para adicionar os botões vazios na lista

            if(botao1.Text == "")
            {
                BotoesVazios.Add(botao1);

            }
            if(botao2.Text == "")
            {
                BotoesVazios.Add(botao2);

            }
            if(botao3.Text == "")
            {
                BotoesVazios.Add(botao3);

            }
            if (botao4.Text == "")
            {
                BotoesVazios.Add(botao4);

            }
            if (botao5.Text == "")
            {
                BotoesVazios.Add(botao5);

            }
            if (botao6.Text == "")
            {
                BotoesVazios.Add(botao6);

            }
            if (botao7.Text == "")
            {
                BotoesVazios.Add(botao7);

            }
            if (botao8.Text == "")
            {
                BotoesVazios.Add(botao8);

            }
            if (botao9.Text == "")
            {
                BotoesVazios.Add(botao9);

            }

            //se existir botões vazios, o sistema escolherá um de forma aleatória
            if(BotoesVazios.Count > 0)
            {
                Random jogadaAleatoria = new Random();
                int posicao = jogadaAleatoria.Next(BotoesVazios.Count); //escolhe uma posição vazia de forma aleatória
                BotoesVazios[posicao].Text = "O"; //preenche o botão com O
                count2++; //incrementa o contador
                Ganhador();

                count = 0; //zera o contador para que o primeiro jogador jogue de novo
            }

        }


        private void BotaoReiniciar()
        {
            botao1.Text = "";
            botao2.Text = "";
            botao3.Text = "";
            botao4.Text = "";
            botao5.Text = "";
            botao6.Text = "";
            botao7.Text = "";
            botao8.Text = "";
            botao9.Text = "";
            count = 0;
            count2 = 0;
            botao1.Enabled = true; //isso ativa novamente os botões após reinicia-los
            botao2.Enabled = true;
            botao3.Enabled = true;
            botao4.Enabled = true;
            botao5.Enabled = true;
            botao6.Enabled = true;
            botao7.Enabled = true;
            botao8.Enabled = true;
            botao9.Enabled = true;

            JogoFinalizado = false; //com isso, permite um novo jogo
        }

        private void botao10_Click(object sender, EventArgs e)
        {
            BotaoReiniciar();
        }

        
        private void Empate()
        {
            JogoFinalizado = true;
            botao1.Enabled = false; //isso desativa o botão
            botao2.Enabled = false;
            botao3.Enabled = false;
            botao4.Enabled = false;
            botao5.Enabled = false;
            botao6.Enabled = false;
            botao7.Enabled = false;
            botao8.Enabled = false;
            botao9.Enabled = false;
            MessageBox.Show("Deu Empate!");  //mostra a caixa de diálogo
        }

        private void Ganhador()
        {
            //para o jogador 1 (X)
            if(botao1.Text != "")
            {
                if(botao1.Text == "X")
                {
                    if (botao1.Text == botao4.Text && botao4.Text == botao7.Text)
                    {
                        JogoFinalizado = true;
                        //botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        botao3.Enabled = false;
                        //botao4.Enabled = false;
                        botao5.Enabled = false;
                        botao6.Enabled = false;
                        //botao7.Enabled = false;
                        botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do primeiro jogador (X)");
                    }
                    else
                    {
                        if (botao1.Text == botao2.Text && botao2.Text == botao3.Text)
                        {
                            JogoFinalizado = true;
                            //botao1.Enabled = false; //isso desativa o botão
                            //botao2.Enabled = false;
                            //botao3.Enabled = false;
                            botao4.Enabled = false;
                            botao5.Enabled = false;
                            botao6.Enabled = false;
                            botao7.Enabled = false;
                            botao8.Enabled = false;
                            botao9.Enabled = false;
                            MessageBox.Show("Vitória do primeiro jogador (X)");
                        }
                        else
                        {
                            if (botao1.Text == botao5.Text && botao5.Text == botao9.Text)
                            {
                                JogoFinalizado = true;
                                //botao1.Enabled = false; //isso desativa o botão
                                botao2.Enabled = false;
                                botao3.Enabled = false;
                                botao4.Enabled = false;
                                //botao5.Enabled = false;
                                botao6.Enabled = false;
                                botao7.Enabled = false;
                                botao8.Enabled = false;
                                //botao9.Enabled = false;
                                MessageBox.Show("Vitória do primeiro jogador (X)");
                            }
                        }
                    }
                }    
            }


            if (botao2.Text != "")
            {
                if(botao2.Text == "X")
                {
                    if (botao2.Text == botao5.Text && botao5.Text == botao8.Text)
                    {
                        JogoFinalizado = true;
                        botao1.Enabled = false; //isso desativa o botão
                        //botao2.Enabled = false;
                        botao3.Enabled = false;
                        botao4.Enabled = false;
                        //botao5.Enabled = false;
                        botao6.Enabled = false;
                        botao7.Enabled = false;
                        //botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do primeiro jogador (X)");
                    }
                }
                
            }


            if(botao3.Text != "")
            {
                if(botao3.Text == "X")
                {
                    if (botao3.Text == botao5.Text && botao5.Text == botao7.Text)
                    {
                        JogoFinalizado = true;
                        botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        //botao3.Enabled = false;
                        botao4.Enabled = false;
                        //botao5.Enabled = false;
                        botao6.Enabled = false;
                        //botao7.Enabled = false;
                        botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do primeiro jogador (X)");
                    }
                    else
                    {
                        if (botao3.Text == botao6.Text && botao6.Text == botao9.Text)
                        {
                            JogoFinalizado = true;
                            botao1.Enabled = false; //isso desativa o botão
                            botao2.Enabled = false;
                            //botao3.Enabled = false;
                            botao4.Enabled = false;
                            botao5.Enabled = false;
                            //botao6.Enabled = false;
                            botao7.Enabled = false;
                            botao8.Enabled = false;
                            //botao9.Enabled = false;
                            MessageBox.Show("Vitória do primeiro jogador (X)");
                        }
                    }
                }
                
            }

            if(botao4.Text != "")
            {
                if(botao4.Text == "X")
                {
                    if (botao4.Text == botao5.Text && botao5.Text == botao6.Text)
                    {
                        JogoFinalizado = true;
                        botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        botao3.Enabled = false;
                        //botao4.Enabled = false;
                        //botao5.Enabled = false;
                        //botao6.Enabled = false;
                        botao7.Enabled = false;
                        botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do primeiro jogador (X)");
                    }
                }
                
            }

            if(botao7.Text != "")
            {
                if(botao7.Text == "X")
                {
                    if (botao7.Text == botao8.Text && botao8.Text == botao9.Text)
                    {
                        JogoFinalizado = true;
                        botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        botao3.Enabled = false;
                        botao4.Enabled = false;
                        botao5.Enabled = false;
                        botao6.Enabled = false;
                        //botao7.Enabled = false;
                        //botao8.Enabled = false;
                        //botao9.Enabled = false;
                        MessageBox.Show("Vitória do primeiro jogador (X)");
                    }
                }
                
            }


            //para o jogador 2 (O)
            if (botao1.Text != "")
            {
                if (botao1.Text == "O")
                {
                    if (botao1.Text == botao4.Text && botao4.Text == botao7.Text)
                    {
                        JogoFinalizado = true;
                        //botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        botao3.Enabled = false;
                        //botao4.Enabled = false;
                        botao5.Enabled = false;
                        botao6.Enabled = false;
                        //botao7.Enabled = false;
                        botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do segundo jogador (O)");
                    }
                    else
                    {
                        if (botao1.Text == botao2.Text && botao2.Text == botao3.Text)
                        {
                            JogoFinalizado = true;
                            //botao1.Enabled = false; //isso desativa o botão
                            //botao2.Enabled = false;
                            //botao3.Enabled = false;
                            botao4.Enabled = false;
                            botao5.Enabled = false;
                            botao6.Enabled = false;
                            botao7.Enabled = false;
                            botao8.Enabled = false;
                            botao9.Enabled = false;
                            MessageBox.Show("Vitória do segundo jogador (O)");
                        }
                        else
                        {
                            if (botao1.Text == botao5.Text && botao5.Text == botao9.Text)
                            {
                                JogoFinalizado = true;
                                //botao1.Enabled = false; //isso desativa o botão
                                botao2.Enabled = false;
                                botao3.Enabled = false;
                                botao4.Enabled = false;
                                //botao5.Enabled = false;
                                botao6.Enabled = false;
                                botao7.Enabled = false;
                                botao8.Enabled = false;
                                //botao9.Enabled = false;
                                MessageBox.Show("Vitória do segundo jogador (O)");
                            }
                        }
                    }
                }
            }


            if (botao2.Text != "")
            {
                if (botao2.Text == "O")
                {
                    if (botao2.Text == botao5.Text && botao5.Text == botao8.Text)
                    {
                        botao1.Enabled = false; //isso desativa o botão
                        //botao2.Enabled = false;
                        botao3.Enabled = false;
                        botao4.Enabled = false;
                        //botao5.Enabled = false;
                        botao6.Enabled = false;
                        botao7.Enabled = false;
                        //botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do segundo jogador (O)");
                    }
                }

            }


            if (botao3.Text != "")
            {
                if (botao3.Text == "O")
                {
                    if (botao3.Text == botao5.Text && botao5.Text == botao7.Text)
                    {
                        botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        //botao3.Enabled = false;
                        botao4.Enabled = false;
                        //botao5.Enabled = false;
                        botao6.Enabled = false;
                        //botao7.Enabled = false;
                        botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do segundo jogador (O)");
                    }
                    else
                    {
                        if (botao3.Text == botao6.Text && botao6.Text == botao9.Text)
                        {
                            botao1.Enabled = false; //isso desativa o botão
                            botao2.Enabled = false;
                            //botao3.Enabled = false;
                            botao4.Enabled = false;
                            botao5.Enabled = false;
                            //botao6.Enabled = false;
                            botao7.Enabled = false;
                            botao8.Enabled = false;
                            //botao9.Enabled = false;
                            MessageBox.Show("Vitória do segundo jogador (O)");
                        }
                    }
                }

            }

            if (botao4.Text != "")
            {
                if (botao4.Text == "O")
                {
                    if (botao4.Text == botao5.Text && botao5.Text == botao6.Text)
                    {
                        botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        botao3.Enabled = false;
                        //botao4.Enabled = false;
                        //botao5.Enabled = false;
                        //botao6.Enabled = false;
                        botao7.Enabled = false;
                        botao8.Enabled = false;
                        botao9.Enabled = false;
                        MessageBox.Show("Vitória do segundo jogador (O)");
                    }
                }

            }

            if (botao7.Text != "")
            {
                if (botao7.Text == "O")
                {
                    if (botao7.Text == botao8.Text && botao8.Text == botao9.Text)
                    {
                        botao1.Enabled = false; //isso desativa o botão
                        botao2.Enabled = false;
                        botao3.Enabled = false;
                        botao4.Enabled = false;
                        botao5.Enabled = false;
                        botao6.Enabled = false;
                        //botao7.Enabled = false;
                        //botao8.Enabled = false;
                        //botao9.Enabled = false;
                        MessageBox.Show("Vitória do segundo jogador (O)");
                    }
                }

            }



        } //chave da função ganhador
    }
}
