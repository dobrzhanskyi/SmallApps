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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSound_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSound.Checked)
            {
                cbSound.Text = "Звук Есть";
                Sound.SoundOn();
            }
            else
            {
                cbSound.Text = "Звука Нет";
                Sound.SoundOff();
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            StartLevel1();
        }
        private void StartLevel1()
        {
            Sound.PlayStart();
            FormLevel1 level1 = new FormLevel1();
            DialogResult dr = level1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
                StartLevel2();

        }
        private void StartLevel2()
        {
            FormLevel2 level2 = new FormLevel2();
            DialogResult dr = level2.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Sound.PlayWin();
                MessageBox.Show("Вы прошли все уровни лабиринта!", "Победа");
            }
        }
    }
}
