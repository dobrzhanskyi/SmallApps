using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Arcanoid
{
    public partial class FormGame : Form
    {
        static Random rnd = new Random();
        int racketX, racketY;
        int ballX, ballY;
        int racketShiftX = 8;

        int sideLeftX, sideRightX, sideTopX;

        int ballSx, ballSy;
        int ballShiftX = 4;
        int ballShiftY = 3;
        int totalBricks = 5;

        public FormGame()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            MoveBall();
        }
        private void FormGame_Shown(object sender, EventArgs e)
        {
            InitGame();
        }
        private void InitGame()
        {
            racketX = btnRocket.Location.X;
            racketY = btnRocket.Location.Y;
            sideLeftX = lblLeft.Location.X + lblLeft.Width;
            sideRightX = lblRight.Location.X;
            sideTopX = lblTop.Location.X + lblTop.Height;
            ballX = ball.Location.X;
            ballY = ball.Location.Y;
            ballSx = ballShiftX;
            ballSy = -ballShiftY;
            totalBricks = 5;
        }
        private void ShiftRacket(int sx)
        {
            int ax1 = racketX + sx;
            int ax2 = ax1 + btnRocket.Width;
            if (sideLeftX > ax1) ax1 = sideLeftX;
            if (sideRightX < ax2) ax1 = sideRightX - btnRocket.Width;

            racketX = ax1;
            btnRocket.Location = new Point(racketX, racketY);
        }
        private void MoveBall()
        {
            int bx1 = ballX;
            int bx2 = ballX + ball.Width;
            int by1 = ballY;
            int by2 = ballY +ball.Height;         

            ball.Location = new Point(ballX, ballY);

            if (bx1 + ballSx < sideLeftX)
                ballSx = ballShiftX;
            if (bx2 + ballSx > sideRightX)
                ballSx = -ballShiftX;
            if (by1 + ballSy < sideTopX)
                ballSy = ballShiftY;
            if (by2 + ballSy > racketY)
            {              
                int bx0, by0;
                bx0 = (bx1 + bx2)/ 2;
                by0 = (by1 + by2) / 2;

                int rx1, rx2;
                rx1 = racketX;
                rx2 = racketX + btnRocket.Width;
                if (rx1 <= bx0 && bx0 <= rx2)
                    ballSy = -ballShiftY+rnd.Next(-1,2);
                else if (rx1 <= bx2+ ball.Width && bx2+ball.Width <= rx2)
                {
                    ballSx = -ballShiftX+rnd.Next(-1, 2);
                    ballSy = -ballShiftY+ rnd.Next(-1, 2);
                }
                else if (rx1 <= bx1-ball.Width && bx1-ball.Width <= rx2)
                {
                    ballSx = ballShiftX+ rnd.Next(-1, 2);
                    ballSy = -ballShiftY+ rnd.Next(-1, 2);
                }
                else
                    LoseBall();
            }
            ballX += ballSx;
            ballY += ballSy;
            CrossBrick(brick1);
            CrossBrick(brick2);
            CrossBrick(brick3);
            CrossBrick(brick4);
            CrossBrick(brick5);
        }
        private void LoseBall()
        {
            timer.Enabled = false;
            MessageBox.Show("Game Over");
            DialogResult = System.Windows.Forms.DialogResult.Abort;
        }
        private void CrossBrick(Label brick)
        {
            if (!brick.Visible) return;
            int bx0, bx1, bx2,
                by0, by1, by2;
            int rx1, rx2,
                ry1, ry2;

            bx1 = ballX;
            bx2 = ballX + ball.Width;
            bx0 = (bx1 + bx2) / 2;
            by1 = ballY;
            by2 = ballY + ball.Height;
            by0 = (by1 + by2) / 2;
            rx1 = brick.Location.X;
            rx2 = rx1 + brick.Width;
            ry1 = brick.Location.Y;
            ry2 = ry1 + brick.Height;

            if (rx1 <= bx0 && bx0 <= rx2 && ry1 <= by2 && by2 <= ry2)
            {
                DropBrick(brick);
                ballSy = -ballSy;
                return;
            }
            if (rx1 <= bx0 && bx0 <= rx2 && ry1 <= by1 && by1 <= ry2)
            {
                DropBrick(brick);
                ballSy = -ballSy;
                return;
            }
            if (rx1 <= bx2 && bx2 <= rx2 && ry1 <= by0 && by0 <= ry2)
            {
                DropBrick(brick);
                ballSx = -ballSx;
                return;
            }
            if (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by0 && by0 <= ry2)
            {
                DropBrick(brick);
                ballSx = -ballSx;
                return;
            }
            //if ((rx1 <= bx2 && bx2 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
            //    (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by2 && by2 <= ry2) ||
            //    (rx1 <= bx1 && bx1 <= rx2 && ry1 <= by1 && by1 <= ry2) ||
            //    (rx1 <= bx2 && bx2 <= rx2 && ry1 <= by1 && by1 <= ry2) )
            //{
            //    DropBrick(brick);
            //    ballSy = -ballSy;
            //    ballSx = -ballSx;
            //    return;
            //}
        }
        private void DropBrick(Label brick)
        {
            brick.Visible = false;
            totalBricks--;
            if (totalBricks == 0)
            {
                MessageBox.Show("You Win !!!");
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }

        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Left: ShiftRacket(-racketShiftX); break;
                case Keys.Right: ShiftRacket(racketShiftX); break;
                case Keys.Enter: timer.Enabled = true; break;
            }
        }
    }
}
