using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace notepad2
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 ff1)
        {
            f1 = ff1;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "Notepad";
            this.textBox1.Text = "DO you want to save changes to GHANWA?";
                this.button1.Text="Save";
            this.button2.Text="Don't Save";
            this.button3.Text="Cancel";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string sd = saveFileDialog1.FileName;
                sd += ".txt";
                File.WriteAllText(sd, this.textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1.Show();
            f1.textBox1.Text = " ";
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
