
namespace Projeto_Web
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ShowHideMenuBtn = new System.Windows.Forms.Button();
            this.Perfilbtn = new System.Windows.Forms.Button();
            this.Pesquisarbtn = new System.Windows.Forms.TextBox();
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Animebtn = new System.Windows.Forms.Button();
            this.Seriesbtn = new System.Windows.Forms.Button();
            this.Filmesbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Solicitacoesbtn = new System.Windows.Forms.Button();
            this.Comunidadebtn = new System.Windows.Forms.Button();
            this.TimerSlidingPanel = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ShowHideMenuBtn);
            this.panel1.Controls.Add(this.Perfilbtn);
            this.panel1.Controls.Add(this.Pesquisarbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 40);
            this.panel1.TabIndex = 0;
            // 
            // ShowHideMenuBtn
            // 
            this.ShowHideMenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowHideMenuBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowHideMenuBtn.Location = new System.Drawing.Point(0, 0);
            this.ShowHideMenuBtn.Name = "ShowHideMenuBtn";
            this.ShowHideMenuBtn.Size = new System.Drawing.Size(41, 40);
            this.ShowHideMenuBtn.TabIndex = 0;
            this.ShowHideMenuBtn.Text = "Image";
            this.ShowHideMenuBtn.UseVisualStyleBackColor = false;
            this.ShowHideMenuBtn.Click += new System.EventHandler(this.ShowHideMenuBtn_Click);
            // 
            // Perfilbtn
            // 
            this.Perfilbtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Perfilbtn.Location = new System.Drawing.Point(761, 0);
            this.Perfilbtn.Name = "Perfilbtn";
            this.Perfilbtn.Size = new System.Drawing.Size(75, 40);
            this.Perfilbtn.TabIndex = 2;
            this.Perfilbtn.Text = "Perfil";
            this.Perfilbtn.UseVisualStyleBackColor = true;
            // 
            // Pesquisarbtn
            // 
            this.Pesquisarbtn.Location = new System.Drawing.Point(337, 9);
            this.Pesquisarbtn.Name = "Pesquisarbtn";
            this.Pesquisarbtn.Size = new System.Drawing.Size(127, 23);
            this.Pesquisarbtn.TabIndex = 0;
            this.Pesquisarbtn.Text = "Pesquisar";
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SlidingPanel.Controls.Add(this.panel2);
            this.SlidingPanel.Controls.Add(this.panel3);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 40);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(79, 385);
            this.SlidingPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Animebtn);
            this.panel2.Controls.Add(this.Seriesbtn);
            this.panel2.Controls.Add(this.Filmesbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 315);
            this.panel2.TabIndex = 8;
            // 
            // Animebtn
            // 
            this.Animebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Animebtn.Location = new System.Drawing.Point(0, 82);
            this.Animebtn.Name = "Animebtn";
            this.Animebtn.Size = new System.Drawing.Size(79, 41);
            this.Animebtn.TabIndex = 8;
            this.Animebtn.Text = "Animes";
            this.Animebtn.UseVisualStyleBackColor = true;
            // 
            // Seriesbtn
            // 
            this.Seriesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Seriesbtn.Location = new System.Drawing.Point(0, 41);
            this.Seriesbtn.Name = "Seriesbtn";
            this.Seriesbtn.Size = new System.Drawing.Size(79, 41);
            this.Seriesbtn.TabIndex = 7;
            this.Seriesbtn.Text = "Séries";
            this.Seriesbtn.UseVisualStyleBackColor = true;
            // 
            // Filmesbtn
            // 
            this.Filmesbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Filmesbtn.Location = new System.Drawing.Point(0, 0);
            this.Filmesbtn.Name = "Filmesbtn";
            this.Filmesbtn.Size = new System.Drawing.Size(79, 41);
            this.Filmesbtn.TabIndex = 6;
            this.Filmesbtn.Text = "Filmes";
            this.Filmesbtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.Solicitacoesbtn);
            this.panel3.Controls.Add(this.Comunidadebtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 385);
            this.panel3.TabIndex = 7;
            // 
            // Solicitacoesbtn
            // 
            this.Solicitacoesbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Solicitacoesbtn.Location = new System.Drawing.Point(0, 344);
            this.Solicitacoesbtn.Name = "Solicitacoesbtn";
            this.Solicitacoesbtn.Size = new System.Drawing.Size(79, 41);
            this.Solicitacoesbtn.TabIndex = 9;
            this.Solicitacoesbtn.Text = "Solicitações";
            this.Solicitacoesbtn.UseVisualStyleBackColor = true;
            this.Solicitacoesbtn.Click += new System.EventHandler(this.Solicitacoesbtn_Click);
            // 
            // Comunidadebtn
            // 
            this.Comunidadebtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Comunidadebtn.Location = new System.Drawing.Point(0, 0);
            this.Comunidadebtn.Name = "Comunidadebtn";
            this.Comunidadebtn.Size = new System.Drawing.Size(79, 40);
            this.Comunidadebtn.TabIndex = 8;
            this.Comunidadebtn.Text = "Comunidade";
            this.Comunidadebtn.UseVisualStyleBackColor = true;
            // 
            // TimerSlidingPanel
            // 
            this.TimerSlidingPanel.Tick += new System.EventHandler(this.TimerSlidingPanel_Tick);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(79, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(757, 146);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(79, 186);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(757, 125);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(79, 311);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(757, 114);
            this.panel6.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 425);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SlidingPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button Perfilbtn;
        private System.Windows.Forms.TextBox Pesquisarbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Solicitacoesbtn;
        private System.Windows.Forms.Button Comunidadebtn;
        private System.Windows.Forms.Button ShowHideMenuBtn;
        private System.Windows.Forms.Timer TimerSlidingPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Animebtn;
        private System.Windows.Forms.Button Seriesbtn;
        private System.Windows.Forms.Button Filmesbtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

