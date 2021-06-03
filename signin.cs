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
    public partial class signin : Form
    {
        public signin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Form1 fe = new Form1();
            fe.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            List<Users> allusers = user.GetUsers();
           
            bool userfound = false;
            foreach (Users item in allusers)
            {
                if (txtusernamesignin.Text==item.Username && txtpasswordsignin.Text==item.Password)
                {
                    userfound = true;
                }
            }
            if (userfound==true)
            {
                main_menue mm = new main_menue();
                this.Hide();
                mm.Show();
            }
            else
            {
                Console.Beep();
                MessageBox.Show("Your credentials are incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
