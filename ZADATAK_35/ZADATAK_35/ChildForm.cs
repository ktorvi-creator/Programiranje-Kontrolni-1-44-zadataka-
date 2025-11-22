using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZADATAK_35
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        public void LoadFile(string path)
        {
            if (File.Exists(path))
            {
                richTextBox1.Text = File.ReadAllText(path);
            }
        }

        public void LoadImage(string path)
        {
            if (File.Exists(path))
            {
                pictureBox1.Image = Image.FromFile(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            pictureBox1.Image = null;
        }
    }
}
