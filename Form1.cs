using System.Windows.Forms;

namespace Navigateur2024
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // webBrowser1.Navigate(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // webBrowser1.GoForward();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // webBrowser1.Refresh();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigateur développé par ta mère.");
        }
    }
}
