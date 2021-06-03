using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tshepiso_Mohatlane__Project_1
{
    public partial class multi : Form
    {
        public multi()
        {
            InitializeComponent();
        }
        public string scores
        {
            get { return score.ToString(); }
        }
        int count = 0;
        int score;

        private void btnhipop_Click(object sender, EventArgs e)
        {
            lblcorrectdrake.Show();
            lblcorrectdrake.Text = "CORRECT ANSWER ";
            btnhipop.BackColor = Color.Green;
            pbcorrect.Show();
            //lblincorrectdrake.Hide();

            pnlcarly.Show();


            if (pbcorrect.Visible)
            {
                count += 5;

            }

            lblscore1.Text = count.ToString();

            lblscore1.Show();

        }

        private void btntrapdrake_Click(object sender, EventArgs e)
        {
            lblcorrectdrake.Show();
            lblcorrectdrake.Text = "CORRECT ANSWER";
            btntrapdrake.BackColor = Color.Green;
            pbcorrect.Show();
            lblscore1.Show();

            // lblincorrectdrake.Hide();
            // pnldrake.Hide();
            pnlcarly.Show();
            if (pbcorrect.Visible)
            {
                count += 5;

            }

            lblscore1.Text = count.ToString();
        }

        private void btnelectrodrake_Click(object sender, EventArgs e)
        {
            btnelectrodrake.BackColor = Color.Red;
            Console.Beep();
            lblincorrectdrake.Show();
            Lblanswer.Show();
            Lblanswer.Text = "Hip pop and trap are correct answers";
            pbwrong.Show();
            lblscore1.Show();
            if (pbcorrect.Visible)
            {
                count += 5;

            }
            else
            {
                count = 0;
            }

            lblscore1.Text = count.ToString();


            //lblcorrectdrake.Hide();
            // pnldrake.Hide();
            pnlcarly.Show();

        }

        private void pnldrake_Paint(object sender, PaintEventArgs e)
        {
            btnstart.Hide();
        }

        private void multi_Load(object sender, EventArgs e)
        {
            lblplayer2name.Hide();
            pnlcarly.Hide();
            pnldrake.Hide();
            lblcorrectdrake.Hide();
            lblincorrectdrake.Hide();
            lblcorrectcarly.Hide();
            lblincorrcarly.Hide();
            lblcorrbabby.Hide();
            lblincorrbaby.Hide();
            lblwrong2.Hide();
            Lblanswer.Hide();
            pbcorrect.Hide();
            pbwrong.Hide();
            lblanswers1.Hide();
            pbwrong1.Hide();
            pbright.Hide();
            pnlbaby.Hide();
            pbwrong2.Hide();
            pbrightt2.Hide();
            pnlealine.Hide();
            lblcorrect3.Hide();
            lblincorrect3.Hide();
            pbtick.Hide();
            lblanswer3.Hide();
            pbcross.Hide();
            lblscore1.Hide();
            lblscore2.Hide();
            lblscore3.Hide();
            lblscore4.Hide();
            btnfinish.Hide();
            btnplayer2.Hide();
         ///   lblname1.Hide();
        }

        private void btnladygag_Click(object sender, EventArgs e)
        {
            pnldrake.Hide();
            Console.Beep();
            btnladygag.BackColor = Color.Red;
            lblincorrcarly.Show();
            lblincorrcarly.Text = "INCORRECT ANSWER";
            lblanswers1.Show();
            lblanswers1.Text = "Carly Rae Japsen is the correct answer";
            pbwrong1.Show();
            pnlbaby.Show();
            lblscore2.Show();
            if (pbright.Visible)
            {
                count += 5;

            }
            else
            {
                count += 0;
            }

            lblscore2.Text = count.ToString();

        }

        private void btntaylor_Click(object sender, EventArgs e)
        {
            pnldrake.Hide();
            Console.Beep();
            btntaylor.BackColor = Color.Red;
            lblincorrcarly.Show();
            lblincorrcarly.Text = "INCORRECT ANSWER";
            lblanswers1.Show();
            lblanswers1.Text = "Carly Rae Japsen is the correct answer";
            pbwrong1.Show();
            pnlbaby.Show();
            lblscore2.Show();
            if (pbright.Visible)
            {
                count += 5;

            }
            else
            {
                count += 0;
                //count += 0;
            }

            lblscore2.Text = count.ToString();

        }

        private void btncarly_Click(object sender, EventArgs e)
        {

            pnldrake.Hide();
            btncarly.BackColor = Color.Green;
            lblcorrectcarly.Show();
            lblcorrectcarly.Text = "CORRECT ANSWER";
            pbright.Show();
            lblscore2.Show();

            pnlbaby.Show();
            if (pbright.Visible)
            {
                score = count += 5;


            }
            lblscore2.Text = score.ToString();
        }

        private void pnlcarly_Paint(object sender, PaintEventArgs e)
        {
            btnhipop.Hide();
            btntrapdrake.Hide();
            btnelectrodrake.Hide();

        }

        private void pnlbaby_Paint(object sender, PaintEventArgs e)
        {
            btncarly.Hide();
            btnladygag.Hide();
            btntaylor.Hide();
        }

        private void btnjustin_Click(object sender, EventArgs e)
        {
            pnlcarly.Hide();
            btnjustin.BackColor = Color.Green;
            lblcorrbabby.Show();
            lblcorrbabby.Text = "CORRECT ANSWER";
            pbrightt2.Show();
            pnlealine.Show();
            lblscore3.Show();
            if (pbrightt2.Visible)
            {
                score = count += 5;

            }
            else
            {
                score = count += 0;
            }
            lblscore3.Text = score.ToString();
        }

        private void btndrake_Click(object sender, EventArgs e)
        {
            pnlcarly.Hide();
            Console.Beep();
            btndrake.BackColor = Color.Red;
            lblincorrbaby.Show();
            lblincorrbaby.Text = "INCORRECT ANSWER";
            lblwrong2.Show();
            lblwrong2.Text = "Justin Bieber is the correct answer";
            pbwrong2.Show();
            pnlealine.Show();
            lblscore3.Show();
            if (pbrightt2.Visible)
            {
                score = count += 5;

            }
            else
            {
                score = count += 0;
            }
            lblscore3.Text = score.ToString();
        }

        private void btnfuture_Click(object sender, EventArgs e)
        {
            pnlcarly.Hide();
            Console.Beep();
            btnfuture.BackColor = Color.Red;
            lblincorrbaby.Show();
            lblincorrbaby.Text = "INCORRECT ANSWER";
            lblwrong2.Show();
            lblwrong2.Text = "Justin Bieber is the correct answer";
            pbwrong2.Show();
            pnlealine.Show();
            lblscore2.Show();
            if (pbrightt2.Visible)
            {
                score = count += 5;

            }
            else
            {
                score = count += 0;
            }
            lblscore3.Text = score.ToString();
        }

        private void pnlealine_Paint(object sender, PaintEventArgs e)
        {
            btnfuture.Hide();
            btndrake.Hide();
            btnjustin.Hide();
        }

        private void btnhip_Click(object sender, EventArgs e)
        {
            pnlbaby.Hide();
            Console.Beep();
            btnhip.BackColor = Color.Red;
            lblincorrect3.Show();
            lblincorrect3.Text = "INCORRECT ANSWER";
            lblanswer3.Show();
            lblanswer3.Text = "RNB is the correct answer";
            pbcross.Show();
            btnfinish.Show();
            lblscore4.Show();
            if (pbtick.Visible)
            {
                score = count += 5;


            }
            else
            {
                score = count += 0;
            }
            lblscore4.Text = score.ToString();
        }

        private void btnhouse_Click(object sender, EventArgs e)
        {
            pnlbaby.Hide();
            Console.Beep();
            btnhouse.BackColor = Color.Red;
            lblincorrect3.Show();
            lblincorrect3.Text = "INCORRECT ANSWER";
            lblanswer3.Show();
            lblanswer3.Text = "RNB is the correct answer";
            pbcross.Show();
            btnfinish.Show();
            lblscore4.Show();
            if (pbtick.Visible)
            {
                score = count += 5;


            }
            else
            {
                score = count += 0;
            }
            lblscore4.Text = score.ToString();

        }

        private void btnrnb_Click(object sender, EventArgs e)
        {
            pnlbaby.Hide();
            btnrnb.BackColor = Color.Green;
            lblcorrbabby.Show();
            lblcorrbabby.Text = "CORRECT ANSWER";
            pbtick.Show();
            btnfinish.Show();
            lblscore4.Show();

            if (pbtick.Visible)
            {
                score = count += 5;


            }
            else
            {
                score = count += 0;
            }
            lblscore4.Text = score.ToString();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Thread countDown = new Thread(new ThreadStart(Timer));
            countDown.Start();
            pnldrake.Show();
            Console.Beep();
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            Console.Beep();
            btnhip.Hide();
            btnhouse.Hide();
            btnrnb.Hide();
            btnplayer2.Show();
            MessageBox.Show("It is player 2 chance to play press button player 2 start for player two to begin", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnfinish.Hide();
            pnlealine.Hide();
            

            //EndMultip ee = new EndMultip();
            //ee.scoress = scores;
            //ee.names = name;
           

            //ee.Show();
            //this.Hide();
        }
        public string namer
        {
            set { lblname1.Text = value; }

        }
        public string namer2
        {
            set  { lblplayer2name.Text = value; }
        }
        public string name
        {
            get { return lblname1.Text; }
        }
        public string name2
        {
            get { return lblplayer2name.Text; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            player22 pp = new player22();
            pp.nam1 = name;
            pp.nam2 = name2;
            pp.scoresfromthefirst = scores;

            this.Hide();
            pp.Show();
        }
        int countNumber=300;
        public delegate void Countdown();
        public void Lableupdate()
        {
            if (lblTime.InvokeRequired)
            {
                Countdown cc = new Countdown(Lableupdate);
                this.Invoke(cc);
            }
            else
            {
                lblTime.Text = countNumber.ToString() +" "+ "seconds remaining ";
            }
        }
        public void Timer()
        {

            for (int i = 300; i >= 0; i--)
            {
                Lableupdate();
                countNumber--;
                Thread.Sleep(1000);

            }
            if (countNumber == 0)
            {
                MessageBox.Show("Time up next user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                player22 hh = new player22 ();
                hh.Hide();
            }

        }
    }
}
