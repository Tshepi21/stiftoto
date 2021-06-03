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
    public partial class multiplayerinfor : Form
    {
        public multiplayerinfor()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {


            Form1 ff = new Form1();
            this.Hide();
            ff.Show();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {

            multi mm = new multi();
            mm.namer = name1;
            mm.namer2 = name2;
            this.Hide();
            mm.Show();
        }
        public string name1
        {
            get { return txtname.Text; }
        }
        public string name2
        {
            get { return txtname2.Text; }
        }

        private void multiplayerinfor_Load(object sender, EventArgs e)
        {

        }
    }
    }
