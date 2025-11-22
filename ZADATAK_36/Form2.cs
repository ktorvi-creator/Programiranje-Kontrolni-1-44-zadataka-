using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba11 {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            try {
                int n = Convert.ToInt32(textBox1.Text);
                for(int i = 0; i <= n; i++) {
                    listBox1.Items.Add(i + " ... " + (Math.Sqrt(i)));
                }
            }
            catch{
                MessageBox.Show("Uneliste negativan broj n ili nepostojeci!");
            }
        }
    }
}
