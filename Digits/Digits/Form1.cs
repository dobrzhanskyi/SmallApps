using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digits
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        int buttons = 9;
        int current = 1;
        Random random = new Random();

        private void menu_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Игра с цифрами.
Нажимайте кнопки с цифрами от 1 до 9", "О программе");
        }
        private void menu_game_start_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            for (int i = 1; i <= buttons; i++)
            {
                Button(i).Visible = true;
            }
            for (int i = 1; i <= buttons; i++)
            {
                Button(i).Text = i.ToString();
            }
            for (int i = 1; i < buttons*10; i++)
            {
                SwapButtons();
            }
            current = 1;
        }
        private Button Button(int nr)
        {
            switch (nr)
            {
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                default:return null;
            }
        }

        private void menu_game_exit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SwapButtons()
        {
            int a = random.Next(1,buttons);
            int b = random.Next(1,buttons);
            string text = Button(a).Text;
            Button(a).Text = Button(b).Text;
            Button(b).Text = text;
            current = 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nr = ((Button)sender).Text;
            if (nr == current.ToString())
            {
                ((Button)sender).Visible = false;
                current++;
            }
        }
    }
}
