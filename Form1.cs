using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentalAppVer9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set the form to fullscreen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        // Button click event handlers remain the same
        private void button1_Click(object sender, EventArgs e)
        {
            // Open Form3 and close Form1
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Open Form2 and close Form1
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Open Form5 and close Form1
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Open Form4 and close Form1
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
