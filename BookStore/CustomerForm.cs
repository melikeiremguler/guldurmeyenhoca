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

            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            panel2.Controls.Clear();


            for (int j = 1; j <= data_base_.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[j - 1].getName() + "\n" + data_base_.BookList[j - 1].author;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


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

            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            panel2.Controls.Clear();


            for (int j = 1; j <= data_base_.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[j - 1].getName() + "\n" + data_base_.BookList[j - 1].author;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }

        }

        public void yeniolusturulanButonlarinClickOlayi(object sender, EventArgs e)
        {
            Button tıklananButtonNesnesi = (sender as Button);

        }


        private void bookBtn_Click(object sender, EventArgs e)
        {


            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            panel2.Controls.Clear();


            for (int j = 1; j <= data_base_.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[j - 1].getName() + "\n" + data_base_.BookList[j - 1].author;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }


        }






        private void reklam1picturebox_Click(object sender, EventArgs e)
        {

        }

        private void magazineBtn_Click(object sender, EventArgs e)
        {

            Database data_base_ = Database.get_instance();
            data_base_.MagazineList.Clear();
            data_base_.read_magazine("MagazineTable");
            panel2.Controls.Clear();


            for (int j = 1; j <= data_base_.MagazineList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.MagazineList[j - 1].getName() + "\n" +data_base_.MagazineList[j - 1].issue;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }
        }

        private void musiccdBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MusicCDList.Clear();
            data_base_.read_musiccd("MusicCDTable");
            panel2.Controls.Clear();


            for (int j = 1; j <= data_base_.MusicCDList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                panel2.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.MusicCDList[j - 1].getName() + "\n" + data_base_.MusicCDList[j - 1].singer;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }
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
