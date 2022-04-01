
namespace Projeto_Web
{
    partial class Solicitação
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
            this.ConfirmarBtn = new System.Windows.Forms.Button();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.FilmeRBtn = new System.Windows.Forms.RadioButton();
            this.AnimeRBtn = new System.Windows.Forms.RadioButton();
            this.SeriesRBtn = new System.Windows.Forms.RadioButton();
            this.NameLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConfirmarBtn
            // 
            this.ConfirmarBtn.Location = new System.Drawing.Point(113, 133);
            this.ConfirmarBtn.Name = "ConfirmarBtn";
            this.ConfirmarBtn.Size = new System.Drawing.Size(111, 47);
            this.ConfirmarBtn.TabIndex = 0;
            this.ConfirmarBtn.Text = "Confirmar";
            this.ConfirmarBtn.UseVisualStyleBackColor = true;
            this.ConfirmarBtn.Click += new System.EventHandler(this.ConfirmarBtn_Click);
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Location = new System.Drawing.Point(260, 133);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(111, 47);
            this.CancelarBtn.TabIndex = 1;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // FilmeRBtn
            // 
            this.FilmeRBtn.AutoSize = true;
            this.FilmeRBtn.Location = new System.Drawing.Point(114, 95);
            this.FilmeRBtn.Name = "FilmeRBtn";
            this.FilmeRBtn.Size = new System.Drawing.Size(59, 19);
            this.FilmeRBtn.TabIndex = 2;
            this.FilmeRBtn.TabStop = true;
            this.FilmeRBtn.Text = "Filmes";
            this.FilmeRBtn.UseVisualStyleBackColor = true;
            this.FilmeRBtn.CheckedChanged += new System.EventHandler(this.FilmeRBtn_CheckedChanged);
            // 
            // AnimeRBtn
            // 
            this.AnimeRBtn.AutoSize = true;
            this.AnimeRBtn.Location = new System.Drawing.Point(215, 95);
            this.AnimeRBtn.Name = "AnimeRBtn";
            this.AnimeRBtn.Size = new System.Drawing.Size(65, 19);
            this.AnimeRBtn.TabIndex = 3;
            this.AnimeRBtn.TabStop = true;
            this.AnimeRBtn.Text = "Animes";
            this.AnimeRBtn.UseVisualStyleBackColor = true;
            this.AnimeRBtn.CheckedChanged += new System.EventHandler(this.AnimeRBtn_CheckedChanged);
            // 
            // SeriesRBtn
            // 
            this.SeriesRBtn.AutoSize = true;
            this.SeriesRBtn.Location = new System.Drawing.Point(316, 94);
            this.SeriesRBtn.Name = "SeriesRBtn";
            this.SeriesRBtn.Size = new System.Drawing.Size(55, 19);
            this.SeriesRBtn.TabIndex = 4;
            this.SeriesRBtn.TabStop = true;
            this.SeriesRBtn.Text = "Séries";
            this.SeriesRBtn.UseVisualStyleBackColor = true;
            this.SeriesRBtn.CheckedChanged += new System.EventHandler(this.SeriesRBtn_CheckedChanged);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(69, 55);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(43, 15);
            this.NameLbl.TabIndex = 5;
            this.NameLbl.Text = "Nome:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Por favor, escreva no campo abaixo o nome do filme, série ou anime e depois selec" +
    "ione qual é";
            // 
            // Solicitação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SeriesRBtn);
            this.Controls.Add(this.AnimeRBtn);
            this.Controls.Add(this.FilmeRBtn);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.ConfirmarBtn);
            this.Name = "Solicitação";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmarBtn;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.RadioButton FilmeRBtn;
        private System.Windows.Forms.RadioButton AnimeRBtn;
        private System.Windows.Forms.RadioButton SeriesRBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}