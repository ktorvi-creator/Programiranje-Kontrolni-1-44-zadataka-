namespace ZADATAK_32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Podaci1
        {
            set
            {
                label1.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if(f2.ShowDialog() == DialogResult.OK)
            {
                this.Podaci1 = f2.Podaci2;
            }
            else
            {
                this.Podaci1 = "Odustali ste!";
            }
        }
    }
}
