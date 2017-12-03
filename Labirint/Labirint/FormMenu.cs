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
            Sound.PlayStart();
        }
    }
}
