using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad2
{
    public partial class Form4 : Form
    {
        Form1 f1;
        public Form4(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Find";
            this.button1.Text = "Ok";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f1.textBox1.Text.Contains(this.textBox1.Text))
            {
                MessageBox.Show("Found Successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show("Not Found");
            }
            this.Close();
        }

    }
}
