using System;
using System.Drawing;
using System.Windows.Forms;

namespace test_MDI
{
    public partial class Form2 : Form
    {
        public Form2(string fileName)
        {
            InitializeComponent();

            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Image = Image.FromFile(fileName);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}