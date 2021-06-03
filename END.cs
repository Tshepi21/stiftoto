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
    public partial class END : Form
    {
        public END()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            if (int.Parse(lblscore.Text) < 10)
            {
                pblost.Show();
            }
            else
            {
                pbwin.Show();
            }
        }
        public string  scoress
        {
            set { lblscore.Text=value; }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public string names
        {
            set { lblname.Text = value; }

        }

        private void brnpalyagin_Click(object sender, EventArgs e)
        {
            Singleuserinfor ss = new Singleuserinfor();
            this.Hide();
            ss.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void END_Load(object sender, EventArgs e)
        {
            pblost.Hide();
            pbwin.Hide();
        }
    }
}
