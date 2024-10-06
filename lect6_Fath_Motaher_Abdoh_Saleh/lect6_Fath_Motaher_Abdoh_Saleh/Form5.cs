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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int s = -1, m = 0, h = 0, d = 0;

        private void Form5_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;//الالهاء للمعالج
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            timer1.Enabled=true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer1.Enabled=false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s++;
            if (s<9)
                lblsec.Text = "0" + s.ToString();  
                else
                lblsec.Text = s.ToString();
            if(s>=59)
            {
                timer1.Interval = 90;
                m++;
                s = 0;
                if (m < 9)
                lblmin.Text = "0" + m.ToString();
                else
                 lblmin.Text = m.ToString();
            }
            if(m>=59)
            {
                timer1.Interval = 80;
                h++;
                m = 0;
                if (h < 9)
                    lblmin.Text = "0"+h.ToString();
                else
                    lblhour.Text = h.ToString();

            }
        if(h>24)
            {
                timer1.Interval = 70;
                d++;
                h = 0;
                if (d < 9)
                    lblday.Text = "0" + d.ToString();
                else
                    lblday.Text = d.ToString();
            }
        }
    }
}
