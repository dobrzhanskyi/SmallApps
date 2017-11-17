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
        int racketX, racketY;
        int ballX, ballY;
        int racketShiftX=8;
        int sideLeftX, sideRightX, sideTopX;

        public FormGame()
        {
            InitializeComponent();
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
            
        }
        private void ShiftRacket(int sx)
        {
            int ax1 = racketX + sx;
            int ax2 = ax1 + btnRocket.Width;
            if (sideLeftX > ax1) ax1=sideLeftX;
            if (sideRightX < ax2) ax1=sideRightX-btnRocket.Width;

           
            racketX = ax1;
            btnRocket.Location = new Point(racketX, racketY);
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;

            switch (key)
            {
                case Keys.Left:ShiftRacket(-racketShiftX);break;
                case Keys.Right:ShiftRacket(racketShiftX);break;
            }
        }
    }
}
