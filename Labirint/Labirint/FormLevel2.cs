using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLevel2 : Form
    {
        public FormLevel2()
        {
            InitializeComponent();
        }
        private void StartGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            labelFlash1.Visible = true;
            labelFlash2.Visible = false;
        }
        private void FinishGame()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void RestartGame()
        {

            DialogResult dr = MessageBox.Show("Вы задели стену.\nБудем еще раз играть?", "Вы проиграли!", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.OK)
                StartGame();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void FormLevel2_Shown(object sender, EventArgs e)
        {
            StartGame();
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelDoor_MouseEnter(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void lblKey_MouseEnter(object sender, EventArgs e)
        {
            labelDoor.Visible = false;
            lblKey.Visible = false;
            Sound.PlayKey();
        }

        private void labelFinish_MouseEnter(object sender, EventArgs e)
        {
            FinishGame();
        }

        private void labelFlash1_MouseEnter(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelFlash1.Visible = !labelFlash1.Visible;
            labelFlash2.Visible = !labelFlash2.Visible;

        }
    }
}
