using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lect6_Fath_Motaher_Abdoh_Saleh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = pictureBox1.Height = 250;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.BackColor = Color.Red;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Image.FromFile(@"ibb_university.png");
            this.AutoSize = true;
            toolTip1.SetToolTip(pictureBox1, "picturebox أداة");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
