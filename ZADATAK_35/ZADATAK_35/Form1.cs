namespace ZADATAK_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void otvoriExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Filter = "Excel fajlovi |*.xlsx;*.xls";

            if (excel.ShowDialog() == DialogResult.OK)
            {
                ChildForm f2 = new ChildForm();
                f2.MdiParent = this;
                f2.Show();
                f2.LoadFile(excel.FileName);
            }
        }

        private void otvoriSlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "Slike|*.jpg;*.png;*.bmp;*.jpeg";

            if (image.ShowDialog() == DialogResult.OK)
            {
                ChildForm f2 = new ChildForm();
                f2.MdiParent = this;
                f2.Show();
                f2.LoadImage(image.FileName);
            }
        }

        private void otvoriWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog word = new OpenFileDialog();
            word.Filter = "Word Dokument|*.docx;*.doc";

            if (word.ShowDialog() == DialogResult.OK)
            {
                ChildForm f2 = new ChildForm();
                f2.MdiParent = this;
                f2.Show();
                f2.LoadFile(word.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists("opis.txt"))
            {
                MessageBox.Show(File.ReadAllText("opis.txt"), "O Programu");
            }
            else
            {
                MessageBox.Show("Fajl opis.txt ne postoji!\n Proverite putanju fajla!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
