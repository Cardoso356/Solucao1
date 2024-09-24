namespace Projeto1
{
    partial class Form3
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
            dataGridView1 = new DataGridView();
            NomeColuna = new DataGridViewTextBoxColumn();
            JogosFacilColuna = new DataGridViewTextBoxColumn();
            VitoriasFacilColuna = new DataGridViewTextBoxColumn();
            JogosDificilColuna = new DataGridViewTextBoxColumn();
            VitoriasDificilColuna = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NomeColuna, JogosFacilColuna, VitoriasFacilColuna, JogosDificilColuna, VitoriasDificilColuna });
            dataGridView1.Location = new Point(-1, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(758, 261);
            dataGridView1.TabIndex = 0;
            // 
            // NomeColuna
            // 
            NomeColuna.HeaderText = "Nome";
            NomeColuna.Name = "NomeColuna";
            // 
            // JogosFacilColuna
            // 
            JogosFacilColuna.HeaderText = "Jogos (Fácil)";
            JogosFacilColuna.Name = "JogosFacilColuna";
            // 
            // VitoriasFacilColuna
            // 
            VitoriasFacilColuna.HeaderText = "Vitorias (Facil)";
            VitoriasFacilColuna.Name = "VitoriasFacilColuna";
            // 
            // JogosDificilColuna
            // 
            JogosDificilColuna.HeaderText = "Jogos (Difícil)";
            JogosDificilColuna.Name = "JogosDificilColuna";
            // 
            // VitoriasDificilColuna
            // 
            VitoriasDificilColuna.HeaderText = "Vitorias (Dificil)";
            VitoriasDificilColuna.Name = "VitoriasDificilColuna";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Ranking dos Jogadores";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NomeColuna;
        private DataGridViewTextBoxColumn JogosFacilColuna;
        private DataGridViewTextBoxColumn VitoriasFacilColuna;
        private DataGridViewTextBoxColumn JogosDificilColuna;
        private DataGridViewTextBoxColumn VitoriasDificilColuna;
    }
}