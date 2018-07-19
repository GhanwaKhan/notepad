﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad2
{
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Text = "Replace";
            this.button1.Text = "Replace";
            this.button2.Text = "Clear";
            this.label1.Text = "Replace";
            this.label2.Text = "To";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
            f1.textBox1.Text = f1.textBox1.Text.Replace(this.textBox1.Text, this.textBox2.Text);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
        }
    }
}
