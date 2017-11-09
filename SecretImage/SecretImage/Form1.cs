using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretImage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._1;
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._2;
        }

        private void btnShow3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._3;
        }

        private void btnShow4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources._4;
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                BackgroundImage = Properties.Resources.sec;
            }
        }
    }
}
