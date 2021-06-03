using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Tshepiso_Mohatlane__Project_1
{
    public partial class single : Form
    {
        public single()
        {
            InitializeComponent();
            

        }
        public string scores
        {
            get { return score.ToString(); }
        }
        int count = 0;
        int score;

        private void button12_Click(object sender, EventArgs e)
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










            //pnldrake.Hide();

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

        private void pnlcarly_Paint(object sender, PaintEventArgs e)
        {
           
            btnhipop.Hide();
            btntrapdrake.Hide();
            btnelectrodrake.Hide();
            
        }

        private void single_Load(object sender, EventArgs e)
        {
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
            lblname.Hide();
           // lblTime.Hide();
            



        }

        private void pnlbaby_Paint(object sender, PaintEventArgs e)
        {
            btncarly.Hide();
            btnladygag.Hide();
            btntaylor.Hide();
        }

        private void lblwrong2_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
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
                score=count += 0;
            }
            lblscore3.Text = score.ToString();



        }

        private void button17_Click(object sender, EventArgs e)
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

        private void button16_Click(object sender, EventArgs e)
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
           
            //END ee = new END();
            //ee.Show();
            //this.Hide();
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


            //END ee = new END();
            //ee.Show();
            //this.Hide();

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

        private void pnlealine_Paint(object sender, PaintEventArgs e)
        {
            btnfuture.Hide();
            btndrake.Hide();
            btnjustin.Hide();
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
            END ee = new END();
            ee.scoress = scores;
            ee.names = name;
            
            ee.Show();
            this.Hide();

        }
        public string namer
        {
            set { lblname.Text = value; }

        }
        public string name
        {
            get { return lblname.Text; }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

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
                lblTime.Text = countNumber.ToString() +"   " + "seconds remaining ";
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
                MessageBox.Show("Time up", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                END hh = new END();
                hh.Hide();
            }
        }
    }
}