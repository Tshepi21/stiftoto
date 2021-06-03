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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    Users ll = new Users();
            List<Users> alluser = ll.GetUsers();
            if (txtpassowrd.Text!=null && txtusername.Text!=null)
            {
                alluser.Add(new Users(txtusername.Text, txtpassowrd.Text));
                MessageBox.Show("You have succesfully registered", "WELCOME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.Beep();
                main_menue mm = new main_menue();
                this.Hide();
                mm.Show();
            }
            else
            {
                Console.Beep();
                MessageBox.Show("Please fill in your credentials", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusername.Focus();
                txtpassowrd.Focus();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Form1 ff = new Form1();
            this.Hide();
            ff.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
