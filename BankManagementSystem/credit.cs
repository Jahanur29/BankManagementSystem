using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankManagementSystem
{
    public partial class credit : Form
    {
        public credit()
        {
            InitializeComponent();
        }


        int x = 0;
        string zh = "MD. ZAHID HASAN";
        string z = "Devloped By";
        string sh = "Ahmed Soheb Al Hasan";
        string s = "advisor";
        int tam = 25;


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();

            label3.Top += 1;
            //label2.Top += 2;
            if (label3.Top >= this.Width)
                //  {

                label3.Top = label3.Width * -1;
            // }
            Graphics gra = this.CreateGraphics();
            gra.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            gra.DrawString(s, new Font("Calibri", tam), new SolidBrush(Color.Red), 120, x - 200);
            gra.DrawString(sh, new Font("Calibri", tam), new SolidBrush(Color.Green), 120, x - 150);
            

            gra.DrawString(z, new Font("Calibri", tam), new SolidBrush(Color.Red), 120, x-50);
            gra.DrawString(zh, new Font("Calibri", tam), new SolidBrush(Color.Green), 120, x);
            //  }
            x += 1;
            if (x >= this.Width)
                x = zh.Length * tam * -1;
        }
    }
}
