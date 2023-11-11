
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Picsinsert
{
    public partial class Form1 : Form
    {
        Image image1 = Picsinsert.Properties.Resources.confused_cat;
        Image image2 = Picsinsert.Properties.Resources.consfused_girl;


        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = image2;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "icon";
            ofd.Filter = "icon(.png;*.jpg,*.gif;)| *.png;*.jpg;*.gif;";
            ofd.ShowDialog();
            pictureBox2.Image = new Bitmap(ofd.FileName);
        }
    }
}