﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDesign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left - 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Left = pictureBox1.Left + 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top - 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = pictureBox1.Top + 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Top = 70;
            pictureBox1.Left = 50;

        }
    }
}
