using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class CustomerForm : Form
    {

        public CustomerForm()
        {
            InitializeComponent();
        }
        int t = 1, r = 6;
        private void CustomerForm_Load(object sender, EventArgs e)
        {      

            Database data_base = Database.get_instance();
            data_base.read_value("BookTable");
            panel2.Controls.Clear();
            int i = 0;
            for (int j = 0; j < data_base.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(120 + (j * 50), 120);
                pictureBox1.Name = "pictureBox" + j;
                pictureBox1.Size = new System.Drawing.Size(200 * j, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\reklamimage\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //  pictureBox1.BackColor = Color.Honeydew;
                pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

            }

            this.IsMdiContainer = true;

            reklam1picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            reklam2picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            reklam2picturebox.ImageLocation = Application.StartupPath + @"\reklamimage\" + "6.jpg";
            reklam1picturebox.ImageLocation = Application.StartupPath + @"\reklamimage\" + "1.jpg";

        }

        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

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
            reklam1picturebox.ImageLocation = Application.StartupPath + @"\reklamimage\" + t + ".jpg";
            reklam2picturebox.ImageLocation = Application.StartupPath + @"\reklamimage\" + r + ".jpg";

        }

      

        private void billBtn_Click(object sender, EventArgs e)
        {

            //panel1.Controls.Clear(); // Panel'in içini temizliyoruz..
            //panel1.Visible = true;
            //BillForm billForm = new BillForm();
            //billForm.TopLevel = false;
            //panel1.Controls.Add(billForm); // panel1 içerisinde formu ekledik

            //billForm.Show(); // formu gösterdik. Ancak buraya dikakt. ShowDialog(); olarak değil Show(); olarak açıyoruz.
            //billForm.Dock = DockStyle.Fill; // Açılan formun paneli doldurmasını sağladık.
            //billForm.BringToFront(); // formu panel içinde en öne getirdik

        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "LOGIN")
            {
                LoginForm login = new LoginForm(this);
                login.Show();
            }
            else
            {
                btnLogin.Text = "LOGIN";
                chancePasswordBtn.Visible = false;
                creditcardBtn.Visible = false;
                creditcardBtn.Visible = false;
                SettingBtn.Visible = false;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Database data_base = Database.get_instance();
            data_base.read_value("BookTable");
            panel2.Controls.Clear();
            int i = 0;
            for (int j = 0; j < data_base.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(120 + (j * 50), 120);
                pictureBox1.Name = "pictureBox" + j;
                pictureBox1.Size = new System.Drawing.Size(200 * j, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\reklamimage\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //  pictureBox1.BackColor = Color.Honeydew;
                pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

            }
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();

            Database database = Database.get_instance();
            database.BookList.Clear();
            database.read_value("BookTable");


            int i = 0;
                for (int j = 0; j < database.BookList.Count; j++)
                {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new System.Drawing.Point(120+(j*50), 120);
                pictureBox1.Name = "pictureBox"+j;
                pictureBox1.Size = new System.Drawing.Size(200*j, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" +j+".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                //  pictureBox1.BackColor = Color.Honeydew;
                pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);
                
                }
            
        }

        private void reklam1picturebox_Click(object sender, EventArgs e)
        {

        }

        void OpenForm(Form Openform)
        {
            // Not: Ana Form (Form1) hariç, sadece Form2 olduğu için sadece Form2'yi ele alıyoruz.
            // Başka formlarda olursa hepsini kontrol eder.

            bool state = false;
            // Burada AnaForm üzerinde açık olan mdi formlar içerisinde arama yapıyoruz.
            foreach (Form element in this.MdiChildren)
            {
                if (element.Text == Openform.Text) // Eğer Form2 Form1 üzerinde açık ise : 
                {
                    state = true; // Eğer Form2 AnaForm üzerinde açık ise durum true olacak.
                    element.Activate(); // Form2 zaten açık olduğundan önümüze Form2 gelecektir.
                }
            }
            if (!state) // Eğer Form2 AnaForm üzerinde açık değilse : 
            {
                Openform.MdiParent = this; // Form2'nin ana penceresi olarak AnaForm'u ayarlar.
                Openform.Show(); // Form2'yi açar
            }


        }
    }
}
