using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Web
{
    public partial class MainForm : Form
    {
        int PW;
        bool hide;
        public MainForm()
        {
            InitializeComponent();
            PW = SlidingPanel.Width;
            hide = false;
        }

        private void ShowHideMenuBtn_Click(object sender, EventArgs e)
        {
            TimerSlidingPanel.Start();
        }

        private void TimerSlidingPanel_Tick(object sender, EventArgs e)
        {
            if (hide)
            {
                SlidingPanel.Width = SlidingPanel.Width + 20;
                if (SlidingPanel.Width >= PW)
                {
                    TimerSlidingPanel.Stop();
                    hide = false;
                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width = SlidingPanel.Width - 20;
                if (SlidingPanel.Width <= 0)
                {
                    TimerSlidingPanel.Stop();
                    hide = true;
                    this.Refresh();
                }
            }
        }
        private void Solicitacoesbtn_Click(object sender, EventArgs e)
        {
            Solicitação solicitação = new Solicitação();
            solicitação.ShowDialog();
        }
    }
}
