using System.Drawing;
using System.Windows.Forms;

namespace Labirint
{
    public partial class FormLevel1 : Form
    {
        int boxLeft=6;
        public FormLevel1()
        {
            InitializeComponent();
            StartGame();
        }

        
        private void StartGame()
        {
            Point point = labelStart.Location;
            point.Offset(labelStart.Width / 2, labelStart.Height / 2);
            Cursor.Position = PointToScreen(point);
            boxLeft = 6;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

        }
        private void FinishGame()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        private void RestartGame()
        {
           
             DialogResult dr=MessageBox.Show("Вы задели стену.\nБудем еще раз играть?", "Вы проиграли!",MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.OK)
                StartGame();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
        private void FormLevel1_Shown(object sender, System.EventArgs e)
        {
            StartGame();
        }

        private void labelFinish_MouseEnter(object sender, System.EventArgs e)
        {
            if(boxLeft==0)
            FinishGame();
        }

        private void label3_MouseEnter(object sender, System.EventArgs e)
        {
            RestartGame();
        }

        private void label7_MouseEnter(object sender, System.EventArgs e)
        {
           ((Label)sender).Visible = false;
            Sound.PlayKey();
            boxLeft--;
          
        }
    }
}
