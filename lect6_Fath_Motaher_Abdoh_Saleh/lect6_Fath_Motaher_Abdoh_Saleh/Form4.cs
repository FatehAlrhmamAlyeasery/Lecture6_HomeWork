using System;
using System.Drawing;
using System.Windows.Forms;

namespace lect6_Fath_Motaher_Abdoh_Saleh
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            // رسم المربع داخل الـ PictureBox
            int width = pictureBox1.Width - 1;
            int height = pictureBox1.Height - 1;
            Bitmap temp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            // جعل المربع يغطي 80% من عرض وارتفاع الـ PictureBox
            int squareSize = Math.Min(width, height) * 4 / 5;

            // إحداثيات بداية المربع (داخل PictureBox)
            int startX = (width - squareSize) / 2;
            int startY = (height - squareSize) / 2;

            // رسم الحدود الأربعة للمربع داخل PictureBox
            for (int x = startX; x < startX + squareSize; x++)
            {
                temp.SetPixel(x, startY, Color.White); // الحد العلوي
                temp.SetPixel(x, startY + squareSize, Color.White); // الحد السفلي
            }

            for (int y = startY; y < startY + squareSize; y++)
            {
                temp.SetPixel(startX, y, Color.White); // الحد الأيسر
                temp.SetPixel(startX + squareSize, y, Color.White); // الحد الأيمن
            }

            pictureBox1.Image = temp; // تعيين الصورة المحدثة إلى PictureBox

            // رسم المربع في الفورم
            DrawSquareInForm();
        }

        // دالة لرسم المربع داخل الفورم
        private void DrawSquareInForm()
        {
            Graphics g = this.CreateGraphics();

            // حجم المربع (داخل الفورم)
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // جعل المربع يغطي 50% من الفورم
            int formSquareSize = Math.Min(formWidth, formHeight) / 2;

            // إحداثيات بداية المربع (داخل الفورم)
            int formStartX = (formWidth - formSquareSize) / 2;
            int formStartY = (formHeight - formSquareSize) / 2;

            // مسح أي رسومات سابقة على الفورم
            g.Clear(this.BackColor);

            // رسم المربع باستخدام كائن الرسومات
            g.DrawRectangle(Pens.Red, formStartX, formStartY, formSquareSize, formSquareSize);
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Black;
        }
    }
}
