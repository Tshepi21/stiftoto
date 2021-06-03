using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tshepiso_Mohatlane__Project_1
{
    public partial class EndMultip : Form
    {
        public EndMultip()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            //pblost.Hide();
            //pbwin.Hide();
            //if (int.Parse(lblscore.Text) < 10)
            //{
            //    pblost.Show();
            //}
            //else
            //{
            //    pbwin.Show();
            //}
        }
        //public string scoress
        //{
        //    set { lblscore.Text = value; }

        //}
        public string  scoreone
        {
            set { lblscore.Text = value; }
        }
        public string namesone
        {
            set { lblname.Text = value; }

        }
        public string nametwo
        {
            set { lblname2.Text = value; }
        }
        public string scoretwo
        {
            set { lblscore2.Text = value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void brnpalyagin_Click(object sender, EventArgs e)
        {
            main_menue mm = new main_menue();
            this.Hide();
            mm.Show();
        }

        private void btnplayer2_Click(object sender, EventArgs e)
        {
           

        }

        private void EndMultip_Load(object sender, EventArgs e)
        {
            //pnlplayer2.Hide();
            pnlwinner.Hide();
            brnpalyagin.Hide();
            btnexit.Hide();
           
        }

        private void btnwinner_Click(object sender, EventArgs e)
        {
            pnlplayer2.Hide();
            btnexit.Show();
            brnpalyagin.Show();
            pnlplayer1.Hide();
            pnlwinner.Show();

            if (int.Parse(lblscore.Text)>int.Parse(lblscore2.Text))
            {

                lblwinner2.Hide();
                lblwinname.Text= lblname.Text;
               

            }
            else
          if (int.Parse(lblscore.Text) < int.Parse(lblscore2.Text))
            {
                lblwinner2.Hide();
                lblwinname.Text = lblname2.Text;
                
            }
           else if (int.Parse(lblscore.Text) == int.Parse(lblscore2.Text))
            {
                lblwinname.Text = lblname.Text;
                lblwinner2.Text = lblname2.Text;

            }


        }
    }
}
