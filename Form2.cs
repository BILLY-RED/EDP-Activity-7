using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentalAppVer9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            SetFormToFullscreen(); // Set form to fullscreen
        }

        private void SetFormToFullscreen()
        {
            // Set the form to fullscreen
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open Form1 and close Form2
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
