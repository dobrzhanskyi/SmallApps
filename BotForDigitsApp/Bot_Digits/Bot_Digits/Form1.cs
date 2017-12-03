using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Bot_Digits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxX.ResetText();
            textBoxY.ResetText();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int x, y;
            x = Cursor.Position.X;
            y = Cursor.Position.Y;
            textBoxX.Text += x.ToString() + Environment.NewLine;
            textBoxY.Text += y.ToString() + Environment.NewLine;
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        

        public void DoMouseClick(int x,int y)
        {
            Cursor.Position = new Point(x, y); 
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, (uint)x, (uint)y, 0, 0);
        }

        
    
    private void buttonRepeat_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < textBoxX.Lines.Length; j++)
            {
                for (int i = 0; i < textBoxX.Lines.Length-1; i++)
                {
                    int x, y;
                    x = Convert.ToUInt16(textBoxX.Lines[i]);
                    y = Convert.ToUInt16(textBoxY.Lines[i]);
                    DoMouseClick(x, y);
                }
            }
        }
    }
}
