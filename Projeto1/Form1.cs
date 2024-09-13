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
        private void juncaoDosBotoes_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "")
            {
                if (count == 0)
                {
                    ((Button)sender).Text = "X";
                    count++;
                    count2++;
                }
                else
                {
                    ((Button)sender).Text = "O";
                    count--;
                    count2++;
                }
            }

            Ganhador();
            if (count2 == 9)
            {
                Empate();
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
        }

        private void botao10_Click(object sender, EventArgs e)
        {
            BotaoReiniciar();
        }

        
        private void Empate()
        {
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
