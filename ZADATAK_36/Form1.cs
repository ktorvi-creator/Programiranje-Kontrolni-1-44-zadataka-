using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba11 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            Text = "Koren [1, N]";
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e) {

            string path = "C:\\Users\\Ucenik14\\Desktop\\opis.txt";

            if (File.Exists(path)) {
                string text = File.ReadAllText(path);
                MessageBox.Show(text, "O programu");
            }
            else {
                MessageBox.Show("Fajl nije pronađen.", "error!");
            }

        }

        private void koren1NToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 koren = new Form2();
            koren.MdiParent = this;
            koren.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e) {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void kvadrat1NToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3 kvadrat = new Form3();
            kvadrat.MdiParent = this;
            kvadrat.Show();
        }

        private void kub1NToolStripMenuItem_Click(object sender, EventArgs e) {
            Form4 kub = new Form4();
            kub.MdiParent = this;
            kub.Show();
        }
    }
}
