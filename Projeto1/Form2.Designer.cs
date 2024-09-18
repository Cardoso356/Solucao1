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
            Botao_NomedoJogador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            jogoModo_dificil = new RadioButton();
            jogoModo_facil = new RadioButton();
            Botao_IniciarJogo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Botao_NomedoJogador
            // 
            Botao_NomedoJogador.Location = new Point(23, 72);
            Botao_NomedoJogador.Name = "Botao_NomedoJogador";
            Botao_NomedoJogador.Size = new Size(327, 27);
            Botao_NomedoJogador.TabIndex = 0;
            Botao_NomedoJogador.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 23);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
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
            label2.Size = new Size(153, 31);
            label2.TabIndex = 2;
            label2.Text = "Nível do Jogo";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(jogoModo_dificil);
            groupBox1.Controls.Add(jogoModo_facil);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 92);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // jogoModo_dificil
            // 
            jogoModo_dificil.AutoSize = true;
            jogoModo_dificil.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            jogoModo_dificil.Location = new Point(178, 39);
            jogoModo_dificil.Name = "jogoModo_dificil";
            jogoModo_dificil.Size = new Size(108, 42);
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
            jogoModo_facil.Location = new Point(35, 39);
            jogoModo_facil.Name = "jogoModo_facil";
            jogoModo_facil.Size = new Size(92, 42);
            jogoModo_facil.TabIndex = 4;
            jogoModo_facil.TabStop = true;
            jogoModo_facil.Text = "Fácil";
            jogoModo_facil.UseVisualStyleBackColor = true;
            jogoModo_facil.CheckedChanged += jogoModo_facil_CheckedChanged;
            // 
            // Botao_IniciarJogo
            // 
            Botao_IniciarJogo.Location = new Point(23, 239);
            Botao_IniciarJogo.Name = "Botao_IniciarJogo";
            Botao_IniciarJogo.Size = new Size(327, 49);
            Botao_IniciarJogo.TabIndex = 4;
            Botao_IniciarJogo.Text = "Iniciar Jogo";
            Botao_IniciarJogo.UseVisualStyleBackColor = true;
            Botao_IniciarJogo.Click += IniciarJogo_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 335);
            Controls.Add(Botao_IniciarJogo);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(Botao_NomedoJogador);
            Name = "Form2";
            Text = "Dados do Jogador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Botao_NomedoJogador;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private RadioButton jogoModo_facil;
        private RadioButton jogoModo_dificil;
        private Button Botao_IniciarJogo;
    }
}