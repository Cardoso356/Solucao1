namespace Projeto1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EscreveNomedoJogador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            jogoModo_dificil = new RadioButton();
            jogoModo_facil = new RadioButton();
            Botao_IniciarJogo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // EscreveNomedoJogador
            // 
            EscreveNomedoJogador.Location = new Point(20, 54);
            EscreveNomedoJogador.Margin = new Padding(3, 2, 3, 2);
            EscreveNomedoJogador.Name = "EscreveNomedoJogador";
            EscreveNomedoJogador.Size = new Size(287, 23);
            EscreveNomedoJogador.TabIndex = 0;
            EscreveNomedoJogador.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 1;
            label1.Text = "Nome do Jogador";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(127, 25);
            label2.TabIndex = 2;
            label2.Text = "Nível do Jogo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(jogoModo_dificil);
            groupBox1.Controls.Add(jogoModo_facil);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(20, 94);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(286, 69);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // jogoModo_dificil
            // 
            jogoModo_dificil.AutoSize = true;
            jogoModo_dificil.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jogoModo_dificil.Location = new Point(156, 29);
            jogoModo_dificil.Margin = new Padding(3, 2, 3, 2);
            jogoModo_dificil.Name = "jogoModo_dificil";
            jogoModo_dificil.Size = new Size(83, 34);
            jogoModo_dificil.TabIndex = 5;
            jogoModo_dificil.TabStop = true;
            jogoModo_dificil.Text = "Difícil";
            jogoModo_dificil.UseVisualStyleBackColor = true;
            jogoModo_dificil.CheckedChanged += jogoModo_dificil_CheckedChanged;
            // 
            // jogoModo_facil
            // 
            jogoModo_facil.AutoSize = true;
            jogoModo_facil.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jogoModo_facil.Location = new Point(31, 29);
            jogoModo_facil.Margin = new Padding(3, 2, 3, 2);
            jogoModo_facil.Name = "jogoModo_facil";
            jogoModo_facil.Size = new Size(72, 34);
            jogoModo_facil.TabIndex = 4;
            jogoModo_facil.TabStop = true;
            jogoModo_facil.Text = "Fácil";
            jogoModo_facil.UseVisualStyleBackColor = true;
            jogoModo_facil.CheckedChanged += jogoModo_facil_CheckedChanged;
            // 
            // Botao_IniciarJogo
            // 
            Botao_IniciarJogo.Location = new Point(20, 179);
            Botao_IniciarJogo.Margin = new Padding(3, 2, 3, 2);
            Botao_IniciarJogo.Name = "Botao_IniciarJogo";
            Botao_IniciarJogo.Size = new Size(286, 37);
            Botao_IniciarJogo.TabIndex = 4;
            Botao_IniciarJogo.Text = "Iniciar Jogo";
            Botao_IniciarJogo.UseVisualStyleBackColor = true;
            Botao_IniciarJogo.Click += IniciarJogo_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 251);
            Controls.Add(Botao_IniciarJogo);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(EscreveNomedoJogador);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Dados do Jogador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EscreveNomedoJogador;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton jogoModo_facil;
        private RadioButton jogoModo_dificil;
        private Button Botao_IniciarJogo;
    }
}