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
            // webBrowser1.Navigate(textBox1.Text);
            MessageBox.Show("Navigate(textBox1.Text)");
            // MessageBox.Show("Navigate(textBox1.Text)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // webBrowser1.GoBack();
            // webBrowser1.GoBack();
            MessageBox.Show("GoBack()");
            //MessageBox.Show("GoBack()");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // webBrowser1.GoForward();
            MessageBox.Show("GoForward()");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // webBrowser1.Refresh();
            MessageBox.Show("Refresh()");

        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigateur développé par ta des mecs en blouse blanche.");
        }
    }
}
