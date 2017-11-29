using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12Month
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowMonthPicture();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            ShowMonthPicture();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            monthCalendar.Visible = !monthCalendar.Visible;
        }
        private void ShowMonthPicture()
        {
            string month;
            month = monthCalendar.SelectionStart.Month.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile("months\\" + month + ".jpg");
            }
            catch
            {
                MessageBox.Show("Файлы не найдены", "Ошибка");
            }
        }
    }
}
