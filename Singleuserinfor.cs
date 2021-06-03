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
    public partial class Singleuserinfor : Form
    {
        public Singleuserinfor()
        {
            InitializeComponent();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {

            single eee = new single();
            eee.namer = name;

            this.Hide();
            eee.Show();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 ff = new Form1();
            this.Hide();
            ff.Show();

        }

        private void Singleuserinfor_Load(object sender, EventArgs e)
        {

        }
        public string name
        {
            get { return txtname.Text; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
