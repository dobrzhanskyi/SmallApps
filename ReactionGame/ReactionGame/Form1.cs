using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ReactionGame
{
    public partial class FormReaction : Form
    {
        int totalClicks = 10;
        int clickNr = -1;
        int reactTimeMs = 0;
        int waiting = 0;
        int minWaiting = 1;
        int maxWaiting = 3;
        int myCardNr=0;

        Random rand = new Random();
        Stopwatch watch = new Stopwatch();

        public FormReaction()
        {
            InitializeComponent();
            progressBar1.Maximum = totalClicks;
        }
        public void ShowCard(int nr)
        {
            pictureBox1.Visible = nr == 1;
            pictureBox2.Visible = nr == 2;
            pictureBox3.Visible = nr == 3;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clickNr < 0) return;
            if (waiting > 0)
            {
                waiting--;
                if (waiting == 0)
                {
                    myCardNr = rand.Next(1, 4);
                    ShowCard(myCardNr);
                    watch.Restart();
                }
            }         
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            clickNr = 0;
            reactTimeMs = 0;
            btnStart.Enabled = false;         
            NextClick();
        }
        private void NextClick()
        {
            ShowCard(0);
            clickNr++;
            
            waiting = rand.Next(minWaiting*1000/timer1.Interval, maxWaiting*1000/timer1.Interval + 1);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            watch.Stop();
            reactTimeMs += (int)watch.ElapsedMilliseconds;
            progressBar1.Value = clickNr;
            if (clickNr >= totalClicks)
                ShowResult();
            else
                NextClick();
           
        }
        private void ShowResult()
        {
            double sec = reactTimeMs /1000.0 / totalClicks;
            MessageBox.Show("Среднее время реакции:  " + sec.ToString("0.000") + "сек.","Результат");
            btnStart.Enabled = true;
            clickNr = -1;

        }
    }
}
