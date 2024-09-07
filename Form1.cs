using System.Text;

namespace jajaja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string word = "car";
            string inpo = textBox1.Text;
            StringBuilder titd = new StringBuilder(inpo);
            if (inpo != word)
            {
                listBox1.Items.Add(titd);
                MessageBox.Show("WRONG PO");
            }
            else
            {
                MessageBox.Show("CORRECT GUESS");
                Application.Exit();
            }
            textBox1.Clear();
        }
    }
}
