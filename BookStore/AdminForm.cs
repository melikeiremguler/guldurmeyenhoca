using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        int t = 1, r = 6;
        CustomerForm csf;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbPruduct_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            AdminprintPanel.Controls.Clear();


            for (int j = 1; j <= data_base_.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                AdminprintPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[j - 1].getName() + "\n" + data_base_.BookList[j - 1].author;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                AdminprintPanel.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                AdminprintPanel.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }
        }

        private void yeniolusturulanButonlarinClickOlayi(object sender, EventArgs e)
        {
            Button tıklananButtonNesnesi = (sender as Button);
        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            AdminprintPanel.Controls.Clear();


            for (int j = 1; j <= data_base_.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                AdminprintPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[j - 1].getName() + "\n" + data_base_.BookList[j - 1].author;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                AdminprintPanel.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                AdminprintPanel.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }
        }

        private void magazineBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MagazineList.Clear();
            data_base_.read_magazine("MagazineTable");
            AdminprintPanel.Controls.Clear();


            for (int j = 1; j <= data_base_.MagazineList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                AdminprintPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.MagazineList[j - 1].getName() + "\n" + data_base_.MagazineList[j - 1].issue;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                AdminprintPanel.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                AdminprintPanel.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }
        }

        private void musiccdBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MusicCDList.Clear();
            data_base_.read_musiccd("MusicCDTable");
            AdminprintPanel.Controls.Clear();


            for (int j = 1; j <= data_base_.MusicCDList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                AdminprintPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.MusicCDList[j - 1].getName() + "\n" + data_base_.MusicCDList[j - 1].singer;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                AdminprintPanel.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                AdminprintPanel.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            Database database = Database.get_instance();
            database.CustomerList.Clear();
            database.read_customer("UserTable");
            AdminprintPanel.Controls.Clear();
            
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Id", typeof(Int32)), new DataColumn("Name", typeof(string)), new DataColumn("Email", typeof(String)), new DataColumn("UserName", typeof(String)), new DataColumn("Passwword", typeof(String)), new DataColumn("Address", typeof(string)) });
            for (int i = 0; i < database.CustomerList.Count; i++)
            {
                dt.Rows.Add(database.CustomerList[i].customerID, database.CustomerList[i].name, database.CustomerList[i].email, database.CustomerList[i].userName, database.CustomerList[i].password, database.CustomerList[i].Address);
            }
            DataGridView dgv = new DataGridView();
            dgv.AutoSize = true;
            
            Point p = new Point(50,100);
            dgv.BackgroundColor = Color.Honeydew;
            dgv.Location = p;
            dgv.DataSource = dt;
            AdminprintPanel.Controls.Add(dgv);

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");

            AdminprintPanel.Controls.Clear();


            for (int j = 1; j <= data_base_.BookList.Count; j++)
            {
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(180 * j, 80);

                pictureBox1.Size = new System.Drawing.Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + j + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                // pictureBox1.BackColor = Color.Black;
                AdminprintPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[j - 1].getName() + "\n" + data_base_.BookList[j - 1].author;
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                AdminprintPanel.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi;
                btn.BackColor = Color.DarkSeaGreen;
                AdminprintPanel.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;


            }

            this.IsMdiContainer = true;

            reklam1picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            reklam2picturebox.SizeMode = PictureBoxSizeMode.StretchImage;

            reklam2picturebox.ImageLocation = Application.StartupPath + @"\reklamimage\" + "6.jpg";
            reklam1picturebox.ImageLocation = Application.StartupPath + @"\reklamimage\" + "1.jpg";

        }
    }
}
