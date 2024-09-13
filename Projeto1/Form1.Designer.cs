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
            SuspendLayout();
            // 
            // botao1
            // 
            botao1.Location = new Point(14, 47);
            botao1.Name = "botao1";
            botao1.Size = new Size(105, 63);
            botao1.TabIndex = 0;
            botao1.UseVisualStyleBackColor = true;
            botao1.Click += juncaoDosBotoes_Click;
            // 
            // botao2
            // 
            botao2.Location = new Point(152, 47);
            botao2.Name = "botao2";
            botao2.Size = new Size(105, 63);
            botao2.TabIndex = 1;
            botao2.UseVisualStyleBackColor = true;
            botao2.Click += juncaoDosBotoes_Click;
            // 
            // botao3
            // 
            botao3.Location = new Point(291, 47);
            botao3.Name = "botao3";
            botao3.Size = new Size(105, 63);
            botao3.TabIndex = 2;
            botao3.UseVisualStyleBackColor = true;
            botao3.Click += juncaoDosBotoes_Click;
            // 
            // botao4
            // 
            botao4.Location = new Point(14, 140);
            botao4.Name = "botao4";
            botao4.Size = new Size(105, 63);
            botao4.TabIndex = 3;
            botao4.UseVisualStyleBackColor = true;
            botao4.Click += juncaoDosBotoes_Click;
            // 
            // botao5
            // 
            botao5.Location = new Point(152, 140);
            botao5.Name = "botao5";
            botao5.Size = new Size(105, 63);
            botao5.TabIndex = 4;
            botao5.UseVisualStyleBackColor = true;
            botao5.Click += juncaoDosBotoes_Click;
            // 
            // botao6
            // 
            botao6.Location = new Point(291, 140);
            botao6.Name = "botao6";
            botao6.Size = new Size(105, 63);
            botao6.TabIndex = 5;
            botao6.UseVisualStyleBackColor = true;
            botao6.Click += juncaoDosBotoes_Click;
            // 
            // botao7
            // 
            botao7.Location = new Point(14, 230);
            botao7.Name = "botao7";
            botao7.Size = new Size(105, 63);
            botao7.TabIndex = 6;
            botao7.UseVisualStyleBackColor = true;
            botao7.Click += juncaoDosBotoes_Click;
            // 
            // botao8
            // 
            botao8.Location = new Point(152, 230);
            botao8.Name = "botao8";
            botao8.Size = new Size(105, 63);
            botao8.TabIndex = 7;
            botao8.UseVisualStyleBackColor = true;
            botao8.Click += juncaoDosBotoes_Click;
            // 
            // botao9
            // 
            botao9.Location = new Point(291, 230);
            botao9.Name = "botao9";
            botao9.Size = new Size(105, 63);
            botao9.TabIndex = 8;
            botao9.UseVisualStyleBackColor = true;
            botao9.Click += juncaoDosBotoes_Click;
            // 
            // botao10
            // 
            botao10.Location = new Point(14, 320);
            botao10.Name = "botao10";
            botao10.Size = new Size(382, 63);
            botao10.TabIndex = 9;
            botao10.Text = "Reiniciar";
            botao10.UseVisualStyleBackColor = true;
            botao10.Click += botao10_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 416);
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
            Name = "Form1";
            Text = "Jogo da Velha";
            ResumeLayout(false);
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
    }
}
