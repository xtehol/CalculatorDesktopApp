﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input1 = double.Parse(textBox1.Text);
            double input2 = double.Parse(textBox2.Text);
            double result = 0;
            if (radioButton1.Checked == true)
            {
                result = input1 + input2;
            }
            else if (radioButton2.Checked == true)
            {
                result = input1 - input2;
            }
            else if (radioButton3.Checked == true)
            {
                result = input1 * input2;
            }
            else if (radioButton4.Checked == true)
            {
                result = input1 / input2;
            }
            else
            {
                result = 0;
            }

            textBox3.Text = result.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
