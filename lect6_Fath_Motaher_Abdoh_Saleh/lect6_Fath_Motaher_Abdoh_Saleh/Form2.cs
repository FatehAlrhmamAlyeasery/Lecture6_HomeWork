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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.AutoSize = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
           // string filename =textBox1.Text.Trim();
            pictureBox1.Image = Image.FromFile(@textBox1.Text.Trim());

        }
    }
}
