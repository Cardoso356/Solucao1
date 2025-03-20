namespace Projeto1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botao1 = new Button();
            botao2 = new Button();
            botao3 = new Button();
            botao4 = new Button();
            botao5 = new Button();
            botao6 = new Button();
            botao7 = new Button();
            botao8 = new Button();
            botao9 = new Button();
            botao10 = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            opçõesToolStripMenuItem = new ToolStripMenuItem();
            rankingDeJogadoresToolStripMenuItem = new ToolStripMenuItem();
            informarDadosDoJogadorToolStripMenuItem = new ToolStripMenuItem();
            MostraNomeDoJogador = new Label();
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // botao1
            // 
            botao1.Location = new Point(23, 80);
            botao1.Name = "botao1";
            botao1.Size = new Size(105, 63);
            botao1.TabIndex = 0;
            botao1.UseVisualStyleBackColor = true;
            botao1.Click += juncaoDosBotoes_Click;
            // 
            // botao2
            // 
            botao2.Location = new Point(134, 80);
            botao2.Name = "botao2";
            botao2.Size = new Size(105, 63);
            botao2.TabIndex = 1;
            botao2.UseVisualStyleBackColor = true;
            botao2.Click += juncaoDosBotoes_Click;
            // 
            // botao3
            // 
            botao3.Location = new Point(245, 80);
            botao3.Name = "botao3";
            botao3.Size = new Size(105, 63);
            botao3.TabIndex = 2;
            botao3.UseVisualStyleBackColor = true;
            botao3.Click += juncaoDosBotoes_Click;
            // 
            // botao4
            // 
            botao4.Location = new Point(23, 149);
            botao4.Name = "botao4";
            botao4.Size = new Size(105, 63);
            botao4.TabIndex = 3;
            botao4.UseVisualStyleBackColor = true;
            botao4.Click += juncaoDosBotoes_Click;
            // 
            // botao5
            // 
            botao5.Location = new Point(134, 149);
            botao5.Name = "botao5";
            botao5.Size = new Size(105, 63);
            botao5.TabIndex = 4;
            botao5.UseVisualStyleBackColor = true;
            botao5.Click += juncaoDosBotoes_Click;
            // 
            // botao6
            // 
            botao6.Location = new Point(245, 149);
            botao6.Name = "botao6";
            botao6.Size = new Size(105, 63);
            botao6.TabIndex = 5;
            botao6.UseVisualStyleBackColor = true;
            botao6.Click += juncaoDosBotoes_Click;
            // 
            // botao7
            // 
            botao7.Location = new Point(23, 218);
            botao7.Name = "botao7";
            botao7.Size = new Size(105, 63);
            botao7.TabIndex = 6;
            botao7.UseVisualStyleBackColor = true;
            botao7.Click += juncaoDosBotoes_Click;
            // 
            // botao8
            // 
            botao8.Location = new Point(134, 218);
            botao8.Name = "botao8";
            botao8.Size = new Size(105, 63);
            botao8.TabIndex = 7;
            botao8.UseVisualStyleBackColor = true;
            botao8.Click += juncaoDosBotoes_Click;
            // 
            // botao9
            // 
            botao9.Location = new Point(245, 218);
            botao9.Name = "botao9";
            botao9.Size = new Size(105, 63);
            botao9.TabIndex = 8;
            botao9.UseVisualStyleBackColor = true;
            botao9.Click += juncaoDosBotoes_Click;
            // 
            // botao10
            // 
            botao10.Location = new Point(23, 287);
            botao10.Name = "botao10";
            botao10.Size = new Size(327, 63);
            botao10.TabIndex = 9;
            botao10.Text = "Reiniciar";
            botao10.UseVisualStyleBackColor = true;
            botao10.Click += botao10_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 361);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(372, 22);
            statusStrip1.TabIndex = 10;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(121, 17);
            toolStripStatusLabel1.Text = "IFSP - Campus Birigui";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(372, 24);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "Opções";
            // 
            // opçõesToolStripMenuItem
            // 
            opçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rankingDeJogadoresToolStripMenuItem, informarDadosDoJogadorToolStripMenuItem });
            opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            opçõesToolStripMenuItem.Size = new Size(59, 20);
            opçõesToolStripMenuItem.Text = "Opções";
            // 
            // rankingDeJogadoresToolStripMenuItem
            // 
            rankingDeJogadoresToolStripMenuItem.Name = "rankingDeJogadoresToolStripMenuItem";
            rankingDeJogadoresToolStripMenuItem.Size = new Size(218, 22);
            rankingDeJogadoresToolStripMenuItem.Text = "Ranking de Jogadores";
            rankingDeJogadoresToolStripMenuItem.Click += rankingDeJogadoresToolStripMenuItem_Click;
            // 
            // informarDadosDoJogadorToolStripMenuItem
            // 
            informarDadosDoJogadorToolStripMenuItem.Name = "informarDadosDoJogadorToolStripMenuItem";
            informarDadosDoJogadorToolStripMenuItem.Size = new Size(218, 22);
            informarDadosDoJogadorToolStripMenuItem.Text = "Informar Dados do Jogador";
            informarDadosDoJogadorToolStripMenuItem.Click += informarDadosDoJogadorToolStripMenuItem_Click;
            // 
            // MostraNomeDoJogador
            // 
            MostraNomeDoJogador.AutoSize = true;
            MostraNomeDoJogador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MostraNomeDoJogador.Location = new Point(23, 37);
            MostraNomeDoJogador.Name = "MostraNomeDoJogador";
            MostraNomeDoJogador.Size = new Size(0, 21);
            MostraNomeDoJogador.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 383);
            Controls.Add(MostraNomeDoJogador);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Controls.Add(botao10);
            Controls.Add(botao9);
            Controls.Add(botao8);
            Controls.Add(botao7);
            Controls.Add(botao6);
            Controls.Add(botao5);
            Controls.Add(botao4);
            Controls.Add(botao3);
            Controls.Add(botao2);
            Controls.Add(botao1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Jogo da Velha";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botao1;
        private Button botao2;
        private Button botao3;
        private Button botao4;
        private Button botao5;
        private Button botao6;
        private Button botao7;
        private Button botao8;
        private Button botao9;
        private Button botao10;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem rankingDeJogadoresToolStripMenuItem;
        private ToolStripMenuItem informarDadosDoJogadorToolStripMenuItem;
        private Label MostraNomeDoJogador;
    }
}
