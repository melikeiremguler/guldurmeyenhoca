using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    /*! \class AdminForm
     *  \brief It is used to make administrator operations 
     *  \details Add product,delete product,update product etc.
     *           To manage customer account
     *           To learn stock information etc.
     */
    public partial class AdminForm : Form
    {
        int t = 1, r = 6;
        DataGridView dgvstok;
        TextBox AvaiblePasword;
        TextBox NewPassword;
        Label MessageLbl;

        public AdminForm()
        {
            InitializeComponent();
        }


        /*! \fn void timer1_Tick(object sender, EventArgs e)
        *  \brief A timer function.
        *  \details It is used to set advertisement transition
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
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

        /*! \fn void AddBtn_Click(object sender, EventArgs e)
        *  \brief A click listener function.
        *  \details It is used to open adding product form 
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
        private void AddBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        /*! \fn void HomeBtn_Click(object sender, EventArgs e)
        *  \brief A click listener function.
        *  \details It is used to show products in Home Page.
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);
        }

        /*! \fn void bookBtn_Click(object sender, EventArgs e)
         *\brief A click listener function.
        *  \details It is used to show products in Book Page.
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
        private void bookBtn_Click(object sender, EventArgs e)
        {
            AdminForm_Load(sender, e);

        }

        /*! \fn void magazineBtn_Click(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to show products in Magazine Page.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void magazineBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MagazineList.Clear();
            data_base_.read_magazine("MagazineTable");
            AdminprintPanel.Controls.Clear();


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
                lb.Text = data_base_.MagazineList[(k)].getName() + "\n" + data_base_.MagazineList[(k)].type;
                lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                productPanel.Controls.Add(lb);

                Label LbPrice = new Label();
                LbPrice.AutoSize = true;
                LbPrice.Text = data_base_.MagazineList[(k)].getPrice().ToString() + "TL";
                LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                productPanel.Controls.Add(LbPrice);

                PictureBox infoIcon = new PictureBox();
                infoIcon.Size = new Size(25, 25);
                infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                infoIcon.BackColor = Color.Honeydew;

                infoIcon.Name = (k).ToString();
                infoIcon.Click += (s, p) =>
                {
                    var img = s as PictureBox;
                    InfoForm infoForm = new InfoForm();
                    int number = Int32.Parse(img.Name);

                    infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Magazine\" + (number + 1) + ".jpg";
                    infoForm.lnName.Text = data_base_.MagazineList[number].getName();
                    infoForm.lbPage.Text = "Type : " + data_base_.MagazineList[number].type;
                    infoForm.lbDescription.Text = data_base_.MagazineList[number].Description;
                    infoForm.lbPrice.Text = data_base_.MagazineList[number].getPrice().ToString() + " TL";
                    infoForm.lbPublisher.Text = data_base_.MagazineList[number].issue;

                    infoForm.Show();

                };
                productPanel.Controls.Add(infoIcon);

                AdminprintPanel.Controls.Add(productPanel);
                pictureBox1.Name = "pictureBox" + k + 10;
                lb.Name = "lb" + k;
                control++;

                if (control >= data_base_.MagazineList.Count)
                {
                    break;
                }



            }
        }

        /*! \fn void musiccdBtn_Click(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to show products in Music Page.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void musiccdBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MusicCDList.Clear();
            data_base_.read_musiccd("MusicCDTable");
            AdminprintPanel.Controls.Clear();


            int control = 0;
            for (int k = 0; k < data_base_.MusicCDList.Count; k++)
            {
                Panel productPanel = new Panel();
                productPanel.Size = new Size(400, 190);
                productPanel.BorderStyle = BorderStyle.FixedSingle;

                PictureBox pictureBox1 = new PictureBox();
                pictureBox1.Location = new Point(0, 0);

                pictureBox1.Size = new Size(170, 200);
                pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (k + 1) + ".jpg";
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
                LbPrice.Text = data_base_.MusicCDList[(k)].getPrice().ToString() + "TL";
                LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                productPanel.Controls.Add(LbPrice);

                PictureBox playIcon = new PictureBox();
                playIcon.Size = new Size(25, 25);
                playIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "play" + ".jpg";
                playIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 5, pictureBox1.Location.Y + 70);
                playIcon.SizeMode = PictureBoxSizeMode.Zoom;
                playIcon.BackColor = Color.Honeydew;

                playIcon.Name = (k + 1).ToString();
                playIcon.Click += (s, p) =>
                {
                    SoundPlayer player = new SoundPlayer();
                    var img = s as PictureBox;

                    player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Demos\\" + img.Name + ".wav";
                    player.Play();

                };
                productPanel.Controls.Add(playIcon);
                AdminprintPanel.Controls.Add(productPanel);

                pictureBox1.Name = "pictureBox" + k + 10;
                lb.Name = "lb" + k;
                control++;
                if (control >= data_base_.MusicCDList.Count)
                {
                    break;
                }


            }
        }

        /*! \fn void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
         *  \brief A FormClosing listener function.
         *  \details It is used to exit admin form.
         *  \param sender an object.
         *  \param e an FormClosingEventArgs.
         *  \return void
        */
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /*! \fn void customerBtn_Click(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to manage customer account.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void customerBtn_Click(object sender, EventArgs e)
        {
            AdminUser admin = AdminUser.get_instance();
            AdminprintPanel.Controls.Clear();


            DataGridView dgv = new DataGridView();
            dgv.DataSource = admin.printCustomerDetails();
            dgv.AutoSize = true;

            Point p = new Point(50, 100);
            dgv.BackgroundColor = Color.Honeydew;
            dgv.Location = p;

            dgv.ReadOnly = true;
            AdminprintPanel.Controls.Add(dgv);

        }

        /*! \fn void StokBtn_Click(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to manage stock of products.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void StokBtn_Click(object sender, EventArgs e)
        {
            Database database = Database.get_instance();
            database.BookList.Clear();
            database.MagazineList.Clear();
            database.MusicCDList.Clear();
            database.read_book("BookTable");
            database.read_magazine("MagazineTable");
            database.read_musiccd("MusicCDTable");

            AdminprintPanel.Controls.Clear();

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] { new DataColumn("Tür", typeof(string)), new DataColumn("Id", typeof(Int32)), new DataColumn("Name", typeof(string)), new DataColumn("Stok", typeof(Int32)) });
            for (int i = 0; i < database.BookList.Count; i++)
            {
                dt.Rows.Add("BOOK", database.BookList[i].getId(), database.BookList[i].getName(), database.BookList[i].Stok);
            }
            for (int i = 0; i < database.MagazineList.Count; i++)
            {
                dt.Rows.Add("MAGAZINE", database.MagazineList[i].getId(), database.MagazineList[i].getName(), database.MagazineList[i].Stok);
            }
            for (int i = 0; i < database.MusicCDList.Count; i++)
            {
                dt.Rows.Add("MUSİCCD", database.MusicCDList[i].getId(), database.MusicCDList[i].getName(), database.MusicCDList[i].Stok);
            }
            dgvstok = new DataGridView();
            dgvstok.AutoSize = true;

            Point p = new Point(100, 70);
            dgvstok.BackgroundColor = Color.Honeydew;
            dgvstok.Location = p;
            dgvstok.DataSource = dt;
            // dgvstok.ReadOnly = true;
            AdminprintPanel.Controls.Add(dgvstok);

            Button btn = new Button();
            btn.Text = "UPDATE";
            btn.Size = new Size(100, 70);
            btn.Location = new Point(dgvstok.Location.X + dgvstok.Width / 3, dgvstok.Location.Y + 400);
            btn.Click += yeniolusturulanButonlarinClickOlayi_ChangeStock;
            btn.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(btn);

        }

        /*! \fn void yeniolusturulanButonlarinClickOlayi_ChangeStock(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to change stock of products.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void yeniolusturulanButonlarinClickOlayi_ChangeStock(object sender, EventArgs e)
        {

            Database database = Database.get_instance();
            database.BookList.Clear();
            database.MagazineList.Clear();
            database.MusicCDList.Clear();
            database.read_book("BookTable");
            database.read_magazine("MagazineTable");
            database.read_musiccd("MusicCDTable");
            int tempid = -1;
            int newstock = 0;
            int k = database.BookList.Count;
            int j = database.MagazineList.Count + database.BookList.Count;
            int control = -1;
            for (int i = 0; i < database.BookList.Count; i++)
            {

                if (dgvstok.Rows[i].Cells[2].Value.ToString() == database.BookList[i].getName() && Convert.ToInt32(dgvstok.Rows[i].Cells[3].Value.ToString()) != database.BookList[i].Stok)
                {
                    tempid = Convert.ToInt32(dgvstok.Rows[i].Cells[1].Value.ToString());
                    newstock = Convert.ToInt32(dgvstok.Rows[i].Cells[3].Value.ToString());
                    control = 1;
                }

            }
            for (int i = 0; i < database.MagazineList.Count; i++)
            {
                if (dgvstok.Rows[k].Cells[2].Value.ToString() == database.MagazineList[i].getName() && Convert.ToInt32(dgvstok.Rows[k].Cells[3].Value.ToString()) != database.MagazineList[i].Stok)
                {
                    tempid = i;
                    newstock = Convert.ToInt32(dgvstok.Rows[k].Cells[3].Value.ToString());
                    control = 2;
                }
                k++;
            }
            for (int i = 0; i < database.MusicCDList.Count; i++)
            {
                if (dgvstok.Rows[j].Cells[2].Value.ToString() == database.MusicCDList[i].getName() && Convert.ToInt32(dgvstok.Rows[j].Cells[3].Value.ToString()) != database.MusicCDList[i].Stok)
                {
                    tempid = i;
                    newstock = Convert.ToInt32(dgvstok.Rows[j].Cells[3].Value.ToString());
                    control = 3;
                }
                j++;
            }


            using (SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
            {
                try
                {
                    SQLiteCommand cmd = new SQLiteCommand();
                    if (control == 1)
                    {
                        cmd.CommandText = @"Update BookTable Set Stock=@Stock Where Id= " + tempid;
                    }
                    else if (control == 2)
                    {
                        cmd.CommandText = @"Update MagazineTable Set Stock=@Stock Where Id= " + tempid;
                    }
                    else if (control == 3)
                    {
                        cmd.CommandText = @"Update MusicCDTable Set Stock=@Stock Where Id= " + tempid;
                    }

                    cmd.Connection = con;
                    cmd.Parameters.Add(new SQLiteParameter("@Stock", newstock));
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("stock update");
                    }
                    else
                    {
                        MessageBox.Show("stock not update");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //  for (int i = 0; i < database.BookList[i].getTotal(); i++)
            //  {
            //   if(Convert.ToInt32(dgvstok.Rows[i].Cells[3].Value.ToString()) != database.BookList[i].Stok)
            //    {
            //       database.update_value("@Stock", Convert.ToInt32(dgvstok.Rows[i].Cells[3].Value.ToString()), "UPDATE BookTable set Stock=@Stock WHERE Name = " + database.BookList[i].getName());
            //  }
            // }
        }

        /*! \fn void chancePasswordBtn_Click(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to change password of customer.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void chancePasswordBtn_Click(object sender, EventArgs e)
        {
            Database database = Database.get_instance();
            database.CustomerList.Clear();
            database.read_customer("UserTable");

            AdminprintPanel.Controls.Clear();

            Label AvaiblePasswordLbl = new Label();
            AvaiblePasswordLbl.Text = "Avaible Password";
            AvaiblePasswordLbl.Size = new Size(100, 70);
            AvaiblePasswordLbl.Location = new Point(100, 50);
            // Eskisifrelbl.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(AvaiblePasswordLbl);

            AvaiblePasword = new TextBox();
            AvaiblePasword.Size = new Size(100, 70);
            AvaiblePasword.Location = new Point(300, 50);
            AvaiblePasword.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(AvaiblePasword);

            Label NewPasswordlbl = new Label();
            NewPasswordlbl.Text = "New Password";
            NewPasswordlbl.Size = new Size(100, 70);
            NewPasswordlbl.Location = new Point(100, 150);
            // YeniSifrelbl.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(NewPasswordlbl);

            NewPassword = new TextBox();
            NewPassword.Size = new Size(100, 70);
            NewPassword.Location = new Point(300, 150);
            NewPassword.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(NewPassword);

            Button PasswordBtn = new Button();
            PasswordBtn.Text = "Change Password";
            PasswordBtn.Size = new Size(100, 70);
            PasswordBtn.Location = new Point(300, 250);
            PasswordBtn.Click += yeniolusturulanButonlarinClickOlayi_ChangePassword;
            PasswordBtn.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(PasswordBtn);

            MessageLbl = new Label();
            MessageLbl.Text = "";
            MessageLbl.Size = new Size(100, 70);
            MessageLbl.Location = new Point(100, 250);
            // YeniSifrelbl.BackColor = Color.DarkSeaGreen;
            AdminprintPanel.Controls.Add(MessageLbl);


        }

        /*! \fn void yeniolusturulanButonlarinClickOlayi_ChangePassword(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to change password of customer then save it to database.
         *  \param sender an object.
         *  \param e an EventArgs.
         *  \return void
        */
        private void yeniolusturulanButonlarinClickOlayi_ChangePassword(object sender, EventArgs e)
        {

            string truepassword = "";
            string NewPasswordtxt = NewPassword.Text;
            Database database = Database.get_instance();
            database.CustomerList.Clear();
            database.read_customer("UserTable");
            for (int i = 0; i < database.CustomerList.Count; i++)
            {
                if (database.CustomerList[i].userName == "tiv")
                {
                    truepassword = database.CustomerList[i].password;
                }
            }
            if (AvaiblePasword.Text == truepassword)
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
                {
                    try
                    {
                        SQLiteCommand cmd = new SQLiteCommand();
                        cmd.CommandText = @"Update UserTable Set Password=@Password Where Id= 5";
                        cmd.Connection = con;
                        cmd.Parameters.Add(new SQLiteParameter("@Password", NewPasswordtxt));
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        if (i == 1)
                        {
                            MessageLbl.Text = "Password Change";
                            AvaiblePasword.Text = "";
                            NewPassword.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("A" +
                                "Password Not Change");
                            AvaiblePasword.Text = "";
                            NewPassword.Text = "";
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

        /*! \fn void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        *  \brief A selectedindexchanged listener function.
        *  \details It is used to change properties with respect to product.
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
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

        /*! \fn void searchBtn_Click(object sender, EventArgs e)
        *  \brief A click listener function.
        *  \details It is used to search product.
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
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
                    AdminprintPanel.Controls.Clear();
                    int control = 0;
                    for (int k = 0; k < database.BookList.Count; k++)
                    {

                        if (Searchtxt.Text == database.BookList[k].getName())
                        {
                            Panel productPanel = new Panel();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            productPanel.Size = new Size(400, 190);
                            productPanel.BorderStyle = BorderStyle.FixedSingle;
                            pictureBox1.Location = new Point(0, 0);
                            pictureBox1.Size = new Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + (k + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            productPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.BookList[(k)].getName() + "\n" + database.BookList[(k)].author;
                            lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                            lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                            productPanel.Controls.Add(lb);

                            Label LbPrice = new Label();
                            LbPrice.AutoSize = true;
                            LbPrice.Text = database.BookList[(k)].getPrice().ToString() + "TL";
                            LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                            LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                            productPanel.Controls.Add(LbPrice);

                            PictureBox infoIcon = new PictureBox();
                            infoIcon.Size = new Size(25, 25);
                            infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                            infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                            infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                            infoIcon.BackColor = Color.Honeydew;
                            infoIcon.Name = (k + 1).ToString();
                            infoIcon.Click += (s, p) =>
                            {
                                var img = s as PictureBox;
                                InfoForm infoForm = new InfoForm();
                                int number = Int32.Parse(img.Name);

                                infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Book\" + number + ".jpg";
                                infoForm.lnName.Text = database.BookList[number].getName() + "\n" + database.BookList[number].author;
                                infoForm.lbPage.Text = "Page : " + database.BookList[number].page.ToString();
                                infoForm.lbDescription.Text = database.BookList[number].Description;
                                infoForm.lbPrice.Text = database.BookList[number].getPrice().ToString() + " TL";
                                infoForm.lbPublisher.Text = database.BookList[number].publisher;

                                infoForm.Show();


                            };
                            productPanel.Controls.Add(infoIcon);
                            AdminprintPanel.Controls.Add(productPanel);
                            pictureBox1.Name = "pictureBox" + k + 10;
                            lb.Name = "lb" + k;
                            control++;

                            if (control >= database.BookList.Count)
                            {
                                break;
                            }

                        }
                    }
                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    AdminprintPanel.Controls.Clear();
                    int control = 0;

                    for (int k = 0; k < database.BookList.Count; k++)
                    {

                        if (Searchtxt.Text == database.BookList[k].author)
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
                            lb.Text = database.BookList[(k)].getName() + "\n" + database.BookList[(k)].author;
                            lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                            lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                            productPanel.Controls.Add(lb);

                            Label LbPrice = new Label();
                            LbPrice.AutoSize = true;
                            LbPrice.Text = database.BookList[(k)].getPrice().ToString() + "TL";
                            LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                            LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                            productPanel.Controls.Add(LbPrice);

                            PictureBox infoIcon = new PictureBox();
                            infoIcon.Size = new Size(25, 25);
                            infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                            infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                            infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                            infoIcon.BackColor = Color.Honeydew;
                            infoIcon.Name = (k + 1).ToString();
                            infoIcon.Click += (s, p) =>
                            {
                                var img = s as PictureBox;
                                InfoForm infoForm = new InfoForm();
                                int number = Int32.Parse(img.Name);


                                infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Book\" + number + ".jpg";
                                infoForm.lnName.Text = database.BookList[number].getName() + "\n" + database.BookList[number].author;
                                infoForm.lbPage.Text = "Page : " + database.BookList[number].page.ToString();
                                infoForm.lbDescription.Text = database.BookList[number].Description;
                                infoForm.lbPrice.Text = database.BookList[number].getPrice().ToString() + " TL";
                                infoForm.lbPublisher.Text = database.BookList[number].publisher;

                                infoForm.Show();

                            };
                            productPanel.Controls.Add(infoIcon);
                            AdminprintPanel.Controls.Add(productPanel);
                            pictureBox1.Name = "pictureBox" + k + 10;
                            lb.Name = "lb" + k;
                            control++;

                            if (control >= database.BookList.Count)
                            {
                                break;
                            }

                        }
                    }
                }
            }
            if (cmbProduct.SelectedIndex == 1)
            {
                if (cmbFiltre.SelectedIndex == 0)
                {
                    AdminprintPanel.Controls.Clear();
                    int control = 0;
                    for (int i = 0; i < database.MagazineList.Count; i++)
                    {
                        if (Searchtxt.Text == database.MagazineList[i].getName())
                        {
                            Panel productPanel = new Panel();
                            productPanel.Size = new Size(400, 190);
                            productPanel.BorderStyle = BorderStyle.FixedSingle;

                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(0, 0);

                            pictureBox1.Size = new Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            productPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MagazineList[(i)].getName() + "\n" + database.MagazineList[(i)].type;
                            lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                            lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                            productPanel.Controls.Add(lb);

                            Label LbPrice = new Label();
                            LbPrice.AutoSize = true;
                            LbPrice.Text = database.MagazineList[(i)].getPrice().ToString() + "TL";
                            LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                            LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                            productPanel.Controls.Add(LbPrice);

                            PictureBox infoIcon = new PictureBox();
                            infoIcon.Size = new Size(25, 25);
                            infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                            infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                            infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                            infoIcon.BackColor = Color.Honeydew;


                            infoIcon.Name = (i).ToString();
                            infoIcon.Click += (s, p) =>
                            {
                                var img = s as PictureBox;
                                InfoForm infoForm = new InfoForm();
                                int number = Int32.Parse(img.Name);

                                infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Magazine\" + (number + 1) + ".jpg";
                                infoForm.lnName.Text = database.MagazineList[number].getName();
                                infoForm.lbPage.Text = "Type : " + database.MagazineList[number].type;
                                infoForm.lbDescription.Text = database.MagazineList[number].Description;
                                infoForm.lbPrice.Text = database.MagazineList[number].getPrice().ToString() + " TL";
                                infoForm.lbPublisher.Text = database.MagazineList[number].issue;

                                infoForm.Show();

                            };
                            productPanel.Controls.Add(infoIcon);

                            AdminprintPanel.Controls.Add(productPanel);

                            pictureBox1.Name = "pictureBox" + i + 10;

                            lb.Name = "lb" + i;
                            control++;

                            if (control >= database.MagazineList.Count)
                            {
                                break;
                            }

                        }
                    }
                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    AdminprintPanel.Controls.Clear();
                    int control = 0;

                    for (int i = 0; i < database.MagazineList.Count; i++)
                    {
                        if (Searchtxt.Text == database.MagazineList[i].type.ToString())
                        {
                            Panel productPanel = new Panel();
                            productPanel.Size = new Size(400, 190);
                            productPanel.BorderStyle = BorderStyle.FixedSingle;
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(0, 0);

                            pictureBox1.Size = new Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            productPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MagazineList[(i)].getName() + "\n" + database.MagazineList[(i)].type;
                            lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                            lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                            productPanel.Controls.Add(lb);

                            Label LbPrice = new Label();
                            LbPrice.AutoSize = true;
                            LbPrice.Text = database.MagazineList[(i)].getPrice().ToString() + "TL";
                            LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                            LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                            productPanel.Controls.Add(LbPrice);


                            PictureBox infoIcon = new PictureBox();
                            infoIcon.Size = new Size(25, 25);
                            infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                            infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                            infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                            infoIcon.BackColor = Color.Honeydew;

                            infoIcon.Name = (i).ToString();
                            infoIcon.Click += (s, p) =>
                            {
                                var img = s as PictureBox;
                                InfoForm infoForm = new InfoForm();
                                int number = Int32.Parse(img.Name);

                                infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Magazine\" + (number + 1) + ".jpg";
                                infoForm.lnName.Text = database.MagazineList[number].getName();
                                infoForm.lbPage.Text = "Type : " + database.MagazineList[number].type;
                                infoForm.lbDescription.Text = database.MagazineList[number].Description;
                                infoForm.lbPrice.Text = database.MagazineList[number].getPrice().ToString() + " TL";
                                infoForm.lbPublisher.Text = database.MagazineList[number].issue;

                                infoForm.Show();

                            };
                            productPanel.Controls.Add(infoIcon);

                            AdminprintPanel.Controls.Add(productPanel);
                            pictureBox1.Name = "pictureBox" + i + 10;

                            lb.Name = "lb" + i;
                            control++;
                            if (control >= database.MagazineList.Count)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            if (cmbProduct.SelectedIndex == 2)
            {
                if (cmbFiltre.SelectedIndex == 0)
                {
                    AdminprintPanel.Controls.Clear();


                    int control = 0;
                    for (int k = 0; k < database.MusicCDList.Count; k++)
                    {

                        if (Searchtxt.Text == database.MusicCDList[k].getName())
                        {
                            Panel productPanel = new Panel();
                            productPanel.Size = new Size(400, 190);
                            productPanel.BorderStyle = BorderStyle.FixedSingle;
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(0, 0);

                            pictureBox1.Size = new Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (k + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            productPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MusicCDList[(k)].getName() + "\n" + database.MusicCDList[(k)].singer;
                            lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                            lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                            productPanel.Controls.Add(lb);


                            Label LbPrice = new Label();
                            LbPrice.AutoSize = true;
                            LbPrice.Text = database.MusicCDList[(k)].getPrice().ToString() + "TL";
                            LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                            LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                            productPanel.Controls.Add(LbPrice);

                            PictureBox playIcon = new PictureBox();
                            playIcon.Size = new Size(25, 25);
                            playIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "play" + ".jpg";
                            playIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 5, pictureBox1.Location.Y + 70);
                            playIcon.SizeMode = PictureBoxSizeMode.Zoom;
                            playIcon.BackColor = Color.Honeydew;

                            playIcon.Name = (k + 1).ToString();
                            playIcon.Click += (s, p) =>
                            {
                                SoundPlayer player = new SoundPlayer();
                                var img = s as PictureBox;

                                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Demos\\" + img.Name + ".wav";
                                player.Play();

                            };
                            productPanel.Controls.Add(playIcon);
                            AdminprintPanel.Controls.Add(productPanel);

                            pictureBox1.Name = "pictureBox" + k + 10;
                            lb.Name = "lb" + k;
                            control++;
                            if (control >= database.MusicCDList.Count)
                            {
                                break;
                            }

                        }
                    }
                }
                if (cmbFiltre.SelectedIndex == 1)
                {
                    AdminprintPanel.Controls.Clear();

                    int control = 0;

                    for (int k = 0; k < database.MusicCDList.Count; k++)
                    {

                        if (Searchtxt.Text == database.MusicCDList[k].singer)
                        {
                            Panel productPanel = new Panel();
                            productPanel.Size = new Size(400, 190);
                            productPanel.BorderStyle = BorderStyle.FixedSingle;
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(0, 0);

                            pictureBox1.Size = new Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (k + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            productPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MusicCDList[(k)].getName() + "\n" + database.MusicCDList[(k)].singer;
                            lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                            lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                            productPanel.Controls.Add(lb);


                            Label LbPrice = new Label();
                            LbPrice.AutoSize = true;
                            LbPrice.Text = database.MusicCDList[(k)].getPrice().ToString() + "TL";
                            LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                            LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                            productPanel.Controls.Add(LbPrice);

                            PictureBox playIcon = new PictureBox();
                            playIcon.Size = new Size(25, 25);
                            playIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "play" + ".jpg";
                            playIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width + 5, pictureBox1.Location.Y + 70);
                            playIcon.SizeMode = PictureBoxSizeMode.Zoom;
                            playIcon.BackColor = Color.Honeydew;

                            playIcon.Name = (k + 1).ToString();
                            playIcon.Click += (s, p) =>
                            {
                                SoundPlayer player = new SoundPlayer();
                                var img = s as PictureBox;

                                player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Demos\\" + img.Name + ".wav";
                                player.Play();

                            };
                            productPanel.Controls.Add(playIcon);
                            AdminprintPanel.Controls.Add(productPanel);

                            pictureBox1.Name = "pictureBox" + k + 10;
                            lb.Name = "lb" + k;
                            control++;
                            if (control >= database.MusicCDList.Count)
                            {
                                break;
                            }

                        }
                    }
                }
            }

            cmbFiltre.Text = "Select";
            cmbProduct.Text = "Select";
        }
        
        /*! \fn void SettingBtn_Click1(object sender, EventArgs e)
           *  \brief A click listener function.
           *  \details It is used to show setting form.
           *  \param sender an object.
           *  \param e an EventArgs.
           *  \return void
          */

        private void SettingBtn_Click_1(object sender, EventArgs e)
        {
            Settingsform settingsform = new Settingsform();
            settingsform.Show();
        }

        /*! \fn void AdminForm_Load(object sender, EventArgs e)
        *  \brief A load listener function.
        *  \details It is used to load book product into book page.
        *  \param sender an object.
        *  \param e an EventArgs.
        *  \return void
       */
        private void AdminForm_Load(object sender, EventArgs e)
        {


            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");

            AdminprintPanel.Controls.Clear();
            int control = 0;
            for (int k = 0; k < data_base_.BookList.Count; k++)
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
                lb.Text = data_base_.BookList[(k)].getName() + "\n" + data_base_.BookList[(k)].author;
                lb.Font = new Font("Adobe Fan Heiti Std", 12, FontStyle.Bold);
                lb.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y);
                productPanel.Controls.Add(lb);

                Label LbPrice = new Label();
                LbPrice.AutoSize = true;
                LbPrice.Text = data_base_.BookList[(k)].getPrice().ToString() + "TL";
                LbPrice.Font = new Font("Adobe Fan Heiti Std", 16, FontStyle.Bold);
                LbPrice.Location = new Point(pictureBox1.Location.X + +pictureBox1.Width, pictureBox1.Location.Y + 120);
                productPanel.Controls.Add(LbPrice);

                PictureBox infoIcon = new PictureBox();
                infoIcon.Size = new Size(25, 25);
                infoIcon.ImageLocation = Application.StartupPath + @"\Icon\" + "info" + ".jpg";
                infoIcon.Location = new Point(pictureBox1.Location.X + pictureBox1.Width, pictureBox1.Location.Y + 50);
                infoIcon.SizeMode = PictureBoxSizeMode.Zoom;
                infoIcon.BackColor = Color.Honeydew;
                infoIcon.Name = (k + 1).ToString();
                infoIcon.Click += (s, p) =>
                {
                    var img = s as PictureBox;
                    InfoForm infoForm = new InfoForm();
                    int number = Int32.Parse(img.Name);

                    infoForm.picBoxImage.ImageLocation = Application.StartupPath + @"\Book\" + number + ".jpg";
                    infoForm.lnName.Text = data_base_.BookList[number].getName() + "\n" + data_base_.BookList[number].author;
                    infoForm.lbPage.Text = "Page : " + data_base_.BookList[number].page.ToString();
                    infoForm.lbDescription.Text = data_base_.BookList[number].Description;
                    infoForm.lbPrice.Text = data_base_.BookList[number].getPrice().ToString() + " TL";
                    infoForm.lbPublisher.Text = data_base_.BookList[number].publisher;

                    infoForm.Show();

                };
                productPanel.Controls.Add(infoIcon);
                AdminprintPanel.Controls.Add(productPanel);
                pictureBox1.Name = "pictureBox" + k + 10;
                lb.Name = "lb" + k;
                control++;

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
    }
}
