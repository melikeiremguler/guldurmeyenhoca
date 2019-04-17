using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopProje
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        int t = 1, r = 6;

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            r++;
            if (t > 7)
            {
                t = 1;
            }
            if (r > 7)
            {
                r = 1;
            }
            reklam1picturebox.Image = Image.FromFile("C:\\Users\\Tuce Maide Tekes\\Desktop\\guldurmeyenhoca\\oopProje\\bin\\Debug\\reklamimage\\" + t + ".jpg");
            reklam2picturebox.Image = Image.FromFile("C:\\Users\\Tuce Maide Tekes\\Desktop\\guldurmeyenhoca\\oopProje\\bin\\Debug\\reklamimage\\" + r + ".jpg");

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            reklam1picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            reklam2picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            reklam2picturebox.Image = Image.FromFile("C:\\Users\\Tuce Maide Tekes\\Desktop\\guldurmeyenhoca\\oopProje\\bin\\Debug\\reklamimage\\6.jpg");
            reklam1picturebox.Image = Image.FromFile("C:\\Users\\Tuce Maide Tekes\\Desktop\\guldurmeyenhoca\\oopProje\\bin\\Debug\\reklamimage\\1.jpg");

        }
    }
}
