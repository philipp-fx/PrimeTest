﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello PrimeTest!");
            //Add Comment 1 Philipp Server
            //Add Comment 2 Philipp Work
            //Add Comment 3 Jorge
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ShowForm2 = new Form2();
            ShowForm2.Show();
        }
    }
}
