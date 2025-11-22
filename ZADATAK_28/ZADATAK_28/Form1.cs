namespace ZADATAK_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Podaci1
        {
            get
            {
                return textBox1.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Podaci2 = this.Podaci1;
            f2.Show();
        }
    }
}
