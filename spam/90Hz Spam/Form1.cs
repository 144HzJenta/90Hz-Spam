﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _90Hz_Spam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Purple;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Pink;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            BackColor = Color.Black;
        }
    }
}
