﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep();
            register ss = new register();
            ss.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep();
            Environment.Exit(0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep();
            signin ss = new signin();
            ss.Show();
            this.Hide();
        }
    }
}
