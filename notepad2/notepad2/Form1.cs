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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "GHANWA";
            this.undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            this.cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            this.copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            this.pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            this.replaceToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            this.selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            this.timeDateToolStripMenuItem.ShortcutKeys = Keys.F5;
            this.newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            this.openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            this.saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            this.deleteToolStripMenuItem.ShortcutKeys = Keys.Delete;

            this.textBox1.ScrollBars = ScrollBars.Both;

            this.wordwrapToolStripMenuItem.Checked = false;
            this.textBox1.WordWrap = false;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "")
            {
                this.textBox1.Text = " ";
            }
            else
            {
                Form2 F2 = new Form2(this);
                 F2.ShowDialog();
             }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Text(*.txt|*.txt)";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string od = openFileDialog1.FileName;
                od += ".txt";
                File.WriteAllText(od, this.textBox1.Text);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F3 = new Form3(this);
            F3.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = System.DateTime.Today.ToString();
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void withoutColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = false;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void withColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog1.ShowColor = true;
            DialogResult dr = this.fontDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                this.textBox1.ForeColor = this.fontDialog1.Color;
                this.textBox1.Font = this.fontDialog1.Font;
            }
        }

        private void wordwrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (wordwrapToolStripMenuItem.Checked == true)
            {
                wordwrapToolStripMenuItem.Checked = false;
                this.textBox1.WordWrap = false;
            }
            else
            {
                wordwrapToolStripMenuItem.Checked = true;
                this.textBox1.WordWrap = true;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.textBox1.Text = File.ReadAllText(fn);

            }
        }
    }
}
