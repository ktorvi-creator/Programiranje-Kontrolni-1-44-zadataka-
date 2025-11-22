namespace ZADATAK_31
{
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        public delegate void Del(TextBox tb1);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            Del d = f2.Funkcija;
            d(textBox1);
            f2.Show();
        }
    }
}
