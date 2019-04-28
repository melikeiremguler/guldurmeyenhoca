﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class CustomerForm : Form
    {
        int t = 1, r = 6;
        private ArrayList shopping_cart;
        public CustomerForm()
        {
            InitializeComponent();
            shopping_cart = new ArrayList();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {


            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");

            panel2.Controls.Clear();
            int control = 0;
            for (int k = 0; k <= data_base_.BookList.Count; k++)
            {

                Panel productPanel = new Panel();
                PictureBox pictureBox1 = new PictureBox();
                productPanel.Size = new Size(400, 190);
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                pictureBox1.Location = new Point(0, 0);

                pictureBox1.Size = new Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + (k + 1) + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                productPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.BookList[(k)].getName() + "\n" + data_base_.BookList[k].author;
                lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                productPanel.Controls.Add(lb);

                Label LbPrice = new Label();
                LbPrice.AutoSize = true;
                LbPrice.Text = data_base_.BookList[k].getPrice().ToString() + "TL";
                LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                productPanel.Controls.Add(LbPrice);

                PictureBox infoIcon = new PictureBox();
                infoIcon.Size = new Size(25, 25);
                infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                infoIcon.BackColor = Color.Honeydew;
                infoIcon.Name =  (k + 1).ToString();
                infoIcon.Click += (s, p) =>
                {
                    var img = s as PictureBox;
                    InfoForm infoForm = new InfoForm();
                    int number = Int32.Parse(img.Name);

                    infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Book\" + number + ".jpg";
                    infoForm.lnName.Text =data_base_.BookList[number].getName()+"\n"+ data_base_.BookList[number].author ;
                    infoForm.lbPage.Text ="Page : "+ data_base_.BookList[number].page.ToString();
                    infoForm.lbDescription.Text = data_base_.BookList[number].Description;
                    infoForm.lbPrice.Text = data_base_.BookList[number].getPrice().ToString()+" TL";
                    infoForm.lbPublisher.Text = data_base_.BookList[number].publisher;

                    infoForm.Show();

                };
                productPanel.Controls.Add(infoIcon);

                PictureBox addPicture = new PictureBox();
                addPicture.Text = "SEPETE EKLE";
                addPicture.Size = new Size(100, 70);
                addPicture.ImageLocation = Application.StartupPath + @"\Icon\" + "add" + ".jpg";
                addPicture.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 90, pictureBox1.Location.Y + 105);
                addPicture.SizeMode = PictureBoxSizeMode.Zoom;
                addPicture.BackColor = Color.Honeydew;
                addPicture.Click += yeniolusturulanButonlarinClickOlayi;
                productPanel.Controls.Add(addPicture);

                pictureBox1.Name = "pictureBox" + k + 10;
                addPicture.Name = "btn" + k;
                lb.Name = "lb" + k;
                control++;
                panel2.Controls.Add(productPanel);
                if (control >= data_base_.BookList.Count)
                {
                    break;
                }




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
            if (cmbProduct.SelectedIndex == 0)
            {
                cmbFiltre.Items.Clear();
                cmbFiltre.Items.Add("Name");
                cmbFiltre.Items.Add("Author");
            }
            else if (cmbProduct.SelectedIndex == 1)
            {
                cmbFiltre.Items.Clear();
                cmbFiltre.Items.Add("Name");
                cmbFiltre.Items.Add("Issue");
            }
            else if (cmbProduct.SelectedIndex == 2)
            {
                cmbFiltre.Items.Clear();
                cmbFiltre.Items.Add("Name");
                cmbFiltre.Items.Add("Singer");
            }
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
                lbHosgeldin.Text = "";
                lbUserName.Text = "";
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

            CustomerForm_Load(sender, e);

        }

        public void yeniolusturulanButonlarinClickOlayi(object sender, EventArgs e)
        {
            PictureBox tıklananPictureNesnesi = (sender as PictureBox);

            string picture_name = tıklananPictureNesnesi.Name;
            string temp = picture_name.Remove(0, 3);
            string label_name = "lb" + temp;

            //to call related label
            Control label = this.Controls.Find(label_name, true).FirstOrDefault() as Label;

            if (label != null)
            {

            }
            //ShoppingCart shopping_cart = new ShoppingCart();




        }


        private void bookBtn_Click(object sender, EventArgs e)
        {
            CustomerForm_Load(sender, e);

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


            int control = 0;
            for (int k = 0; k < data_base_.MagazineList.Count; k++)
            {

                Panel productPanel = new Panel();
                productPanel.Size = new Size(400, 190);
                productPanel.BorderStyle = BorderStyle.FixedSingle;
                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(0, 0);

                pictureBox1.Size = new Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (k + 1) + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                productPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.MagazineList[k].getName() + "\n" + data_base_.MagazineList[k].type;
                lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                productPanel.Controls.Add(lb);

                Label LbPrice = new Label();
                LbPrice.AutoSize = true;
                LbPrice.Text = data_base_.MagazineList[k].getPrice().ToString() + "TL";
                LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                productPanel.Controls.Add(LbPrice);

                PictureBox infoIcon = new PictureBox();
                infoIcon.Size = new Size(25, 25);
                infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                infoIcon.BackColor = Color.Honeydew;

                infoIcon.Name = (k ).ToString();
                infoIcon.Click += (s, p) =>
                {
                    var img = s as PictureBox;
                    InfoForm infoForm = new InfoForm();
                    int number = Int32.Parse(img.Name);

                    infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Magazine\" + (number+1) + ".jpg";
                    infoForm.lnName.Text = data_base_.MagazineList[number].getName();
                    infoForm.lbPage.Text = "Type : " + data_base_.MagazineList[number].type;
                    infoForm.lbDescription.Text = data_base_.MagazineList[number].Description;
                    infoForm.lbPrice.Text = data_base_.MagazineList[number].getPrice().ToString() + " TL";
                    infoForm.lbPublisher.Text = data_base_.MagazineList[number].issue;

                    infoForm.Show();

                };
                productPanel.Controls.Add(infoIcon);

                PictureBox addPicture = new PictureBox();
                addPicture.Size = new Size(100, 70);
                addPicture.ImageLocation = Application.StartupPath + @"\Icon\" + "add" + ".jpg";
                addPicture.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 90, pictureBox1.Location.Y + 105);
                addPicture.SizeMode = PictureBoxSizeMode.Zoom;
                addPicture.BackColor = Color.Honeydew;
                addPicture.Click += yeniolusturulanButonlarinClickOlayi;
                productPanel.Controls.Add(addPicture);

                pictureBox1.Name = "pictureBox" + k + 10;
                addPicture.Name = "btn" + k;
                lb.Name = "lb" + k;
                control++;
                panel2.Controls.Add(productPanel);
                if (control >= data_base_.MagazineList.Count)
                {
                    break;
                }



            }
        }

        private void musiccdBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MusicCDList.Clear();
            data_base_.read_musiccd("MusicCDTable");
            panel2.Controls.Clear();


            int control = 0;
            for (int k = 0; k < data_base_.MusicCDList.Count; k++)
            {

                Panel productPanel = new Panel();
                productPanel.Size = new Size(400, 190);
                productPanel.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(0, 0);

                pictureBox1.Size = new Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + ((k + 1)) + ".jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.BackColor = Color.Honeydew;
                productPanel.Controls.Add(pictureBox1);

                Label lb = new Label();
                lb.AutoSize = true;
                lb.Text = data_base_.MusicCDList[(k)].getName() + "\n" + data_base_.MusicCDList[(k)].singer;
                lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                productPanel.Controls.Add(lb);

                Label LbPrice = new Label();
                LbPrice.AutoSize = true;
                LbPrice.Text = data_base_.MusicCDList[k].getPrice().ToString() + "TL";
                LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                productPanel.Controls.Add(LbPrice);

                PictureBox playIcon = new PictureBox();
                playIcon.Size = new Size(25, 25);
                playIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "play" + ".jpg";
                playIcon.Location = new Point(pictureBox1.Location.X+ pictureBox1.Width+5, pictureBox1.Location.Y + 70);
                playIcon.SizeMode = PictureBoxSizeMode.Zoom;
                playIcon.BackColor = Color.Honeydew;

                playIcon.Name = (k+1).ToString();
                playIcon.Click += (s, p) =>
                {
                    SoundPlayer player = new SoundPlayer();
                    var img = s as PictureBox;
                    
                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Demos\\" + img.Name + ".wav";
                    player.Play();

                };
                productPanel.Controls.Add(playIcon);

                PictureBox addPicture = new PictureBox();
                addPicture.Size = new Size(100, 70);
                addPicture.ImageLocation = Application.StartupPath + @"\Icon\" + "add" + ".jpg";
                addPicture.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 90, pictureBox1.Location.Y + 105);
                addPicture.SizeMode = PictureBoxSizeMode.Zoom;
                addPicture.BackColor = Color.Honeydew;
                addPicture.Click += yeniolusturulanButonlarinClickOlayi;
                productPanel.Controls.Add(addPicture);

                pictureBox1.Name = "pictureBox" + k + 10;
                addPicture.Name = "btn" + k;
                lb.Name = "lb" + k;
                control++;
                panel2.Controls.Add(productPanel);
                if (control >= data_base_.MusicCDList.Count)
                {
                    break;
                }


            }
        }

        private void customerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        TextBox AvaiblePasword;
        TextBox NewPassword;
        Label MessageLbl;
        private void chancePasswordBtn_Click(object sender, EventArgs e)
        {
            Database database = Database.get_instance();
            database.CustomerList.Clear();
            database.read_customer("UserTable");

            panel2.Controls.Clear();

            Label AvaiblePasswordLbl = new Label();
            AvaiblePasswordLbl.Text = "Avaible Password";
            AvaiblePasswordLbl.Size = new Size(100, 70);
            AvaiblePasswordLbl.Location = new Point(100, 50);
            // Eskisifrelbl.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(AvaiblePasswordLbl);

            AvaiblePasword = new TextBox();
            AvaiblePasword.Size = new Size(100, 70);
            AvaiblePasword.Location = new Point(300, 50);
            AvaiblePasword.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(AvaiblePasword);

            Label NewPasswordlbl = new Label();
            NewPasswordlbl.Text = "New Password";
            NewPasswordlbl.Size = new Size(100, 70);
            NewPasswordlbl.Location = new Point(100, 150);
            // YeniSifrelbl.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(NewPasswordlbl);

            NewPassword = new TextBox();
            NewPassword.Size = new Size(100, 70);
            NewPassword.Location = new Point(300, 150);
            NewPassword.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(NewPassword);

            Button PasswordBtn = new Button();
            PasswordBtn.Text = "Change Password";
            PasswordBtn.Size = new Size(100, 70);
            PasswordBtn.Location = new Point(300, 250);
            PasswordBtn.Click += yeniolusturulanButonlarinClickOlayi_ChangePassword;
            PasswordBtn.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(PasswordBtn);

            MessageLbl = new Label();
            MessageLbl.Text = "";
            MessageLbl.Size = new Size(100, 70);
            MessageLbl.Location = new Point(100, 250);
            // YeniSifrelbl.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(MessageLbl);


        }

        private void yeniolusturulanButonlarinClickOlayi_ChangePassword(object sender, EventArgs e)
        {
            string truepassword = "";
            string NewPasswordtxt = NewPassword.Text;
            Database database = Database.get_instance();
            database.CustomerList.Clear();
            database.read_customer("UserTable");
            int control = -1;
            int tempid = -1;
            for (int i = 0; i < database.CustomerList.Count; i++)
            {
                if (database.CustomerList[i].password == AvaiblePasword.Text)
                {
                    truepassword = database.CustomerList[i].password;
                    control = 1;
                    tempid = database.CustomerList[i].customerID;
                }
            }
            if (control == 1)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
                {
                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"Update UserTable Set Password=@Password Where Id= " + tempid;
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SQLiteParameter("@Password", NewPasswordtxt));
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageLbl.Text = "Password Change";
                        }
                        else
                        {
                            MessageBox.Show("Password Not Change");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            else
            {
                MessageLbl.Text = "Avaible Password Text is wrong !";
            }


        }

        private void billBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            Database database = Database.get_instance();
            database.BookList.Clear();
            database.MagazineList.Clear();
            database.MusicCDList.Clear();
            database.read_book("BookTable");
            database.read_magazine("MagazineTable");
            database.read_musiccd("MusicCDTable");

            if (cmbProduct.SelectedIndex == 0)
            {
                if (cmbFiltre.SelectedIndex == 0)
                {
                    for (int i = 0; i < database.BookList.Count; i++)
                    {
                        if (Searchtxt.Text == database.BookList[i].getName())
                        {
                            panel2.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            panel2.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.BookList[i].getName() + "\n" + database.BookList[i].author;
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

                            pictureBox1.Name = "pictureBox" + i + 10;
                            btn.Name = "btn" + i;
                            lb.Name = "lb" + i;

                        }
                    }

                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    for (int i = 0; i < database.BookList.Count; i++)
                    {
                        if (Searchtxt.Text == database.BookList[i].author)
                        {
                            panel2.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            panel2.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.BookList[i].getName() + "\n" + database.BookList[i].author;
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

                            pictureBox1.Name = "pictureBox" + i + 10;
                            btn.Name = "btn" + i;
                            lb.Name = "lb" + i;

                        }
                    }
                }
            }
            if (cmbProduct.SelectedIndex == 1)
            {
                if (cmbFiltre.SelectedIndex == 0)
                {
                    for (int i = 0; i < database.MagazineList.Count; i++)
                    {
                        if (Searchtxt.Text == database.MagazineList[i].getName())
                        {
                            panel2.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            panel2.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MagazineList[i].getName() + "\n" + database.MagazineList[i].type;
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

                            pictureBox1.Name = "pictureBox" + i + 10;
                            btn.Name = "btn" + i;
                            lb.Name = "lb" + i;

                        }
                    }
                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    for (int i = 0; i < database.MagazineList.Count; i++)
                    {
                        if (Searchtxt.Text == database.MagazineList[i].type.ToString())
                        {
                            panel2.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170 * i, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            panel2.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MagazineList[i].getName() + "\n" + database.MagazineList[i].type;
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

                            pictureBox1.Name = "pictureBox" + i + 10;
                            btn.Name = "btn" + i;
                            lb.Name = "lb" + i;

                        }
                    }
                }
            }
            if (cmbProduct.SelectedIndex == 2)
            {
                if (cmbFiltre.SelectedIndex == 0)
                {
                    for (int i = 0; i < database.MusicCDList.Count; i++)
                    {
                        if (Searchtxt.Text == database.MusicCDList[i].getName())
                        {
                            panel2.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170 * i, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            panel2.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MusicCDList[i].getName() + "\n" + database.MusicCDList[i].singer;
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

                            pictureBox1.Name = "pictureBox" + i + 10;
                            btn.Name = "btn" + i;
                            lb.Name = "lb" + i;

                        }
                    }
                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    for (int i = 0; i < database.MusicCDList.Count; i++)
                    {
                        if (Searchtxt.Text == database.MusicCDList[i].singer)
                        {
                            panel2.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            panel2.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MusicCDList[i].getName() + "\n" + database.MusicCDList[i].singer;
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

                            pictureBox1.Name = "pictureBox" + i + 10;
                            btn.Name = "btn" + i;
                            lb.Name = "lb" + i;

                        }
                    }
                }
            }
            cmbFiltre.Text = "Select";
            cmbProduct.Text = "Select";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
