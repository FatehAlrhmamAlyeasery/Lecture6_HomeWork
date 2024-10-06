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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;
        }
        private void btnopen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "image files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|all files|*.*";//هنا لكي يختار الملفات التي امتددادها هو png  or jpg or gif 
            Bitmap temp = new Bitmap(openFileDialog1.FileName);
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                toolTip1.SetToolTip(pictureBox1,openFileDialog1.FileName);//هنا عملنا مسار الصور التي سوف تضهر عند اختيارها
                pictureBox1.Image = temp;
            }
            else
                MessageBox.Show("لم يتم اختيار صورة يرجى اختيار صورة");
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
