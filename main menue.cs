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
    public partial class main_menue : Form
    {
        public main_menue()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Singleuserinfor ss = new Singleuserinfor();
            this.Hide();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multiplayerinfor mm = new multiplayerinfor();
            this.Hide();
            mm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
