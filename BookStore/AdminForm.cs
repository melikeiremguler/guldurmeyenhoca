using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        DataGridView dgvstok;


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
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {

            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            AdminprintPanel.Controls.Clear();


            int control = 0;
            for (int k = 0; k <= data_base_.BookList.Count / 4; k++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    PictureBox pictureBox1 = new PictureBox();
                    if (k == 0) { pictureBox1.Location = new Point(170 * j, 75); }
                    else { pictureBox1.Location = new Point(170 * j, 350 * k); }

                    pictureBox1.Size = new System.Drawing.Size(170, 200);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + ((k * 4) + j) + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.BackColor = Color.Honeydew;
                    // pictureBox1.BackColor = Color.Black;
                    AdminprintPanel.Controls.Add(pictureBox1);

                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Text = data_base_.BookList[(k * 4) + (j - 1)].getName() + "\n" + data_base_.BookList[(k * 4) + (j - 1)].author;
                    Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                    lb.Location = labelp;
                    AdminprintPanel.Controls.Add(lb);


                    pictureBox1.Name = "pictureBox" + j + 10;

                    lb.Name = "lb" + j;
                    control++;
                    if (control >= data_base_.BookList.Count)
                    {
                        break;
                    }

                }


            }
        }



        private void bookBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");
            AdminprintPanel.Controls.Clear();


            int control = 0;
            for (int k = 0; k <= data_base_.BookList.Count / 4; k++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    PictureBox pictureBox1 = new PictureBox();
                    if (k == 0) { pictureBox1.Location = new Point(170 * j, 75); }
                    else { pictureBox1.Location = new Point(170 * j, 350 * k); }

                    pictureBox1.Size = new System.Drawing.Size(170, 200);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + ((k * 4) + j) + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.BackColor = Color.Honeydew;
                    // pictureBox1.BackColor = Color.Black;
                    AdminprintPanel.Controls.Add(pictureBox1);

                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Text = data_base_.BookList[(k * 4) + (j - 1)].getName() + "\n" + data_base_.BookList[(k * 4) + (j - 1)].author;
                    Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                    lb.Location = labelp;
                    AdminprintPanel.Controls.Add(lb);

                   
                    pictureBox1.Name = "pictureBox" + j + 10;
                   
                    lb.Name = "lb" + j;
                    control++;
                    if (control >= data_base_.BookList.Count)
                    {
                        break;
                    }

                }


            }
        }

        private void magazineBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MagazineList.Clear();
            data_base_.read_magazine("MagazineTable");
            AdminprintPanel.Controls.Clear();



            int control = 0;
            for (int k = 0; k <= data_base_.MagazineList.Count / 4; k++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    PictureBox pictureBox1 = new PictureBox();
                    if (k == 0) { pictureBox1.Location = new Point(170 * j, 75); }
                    else { pictureBox1.Location = new Point(170 * j, 300 * k); }

                    pictureBox1.Size = new System.Drawing.Size(170, 200);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + ((k * 4) + j) + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.BackColor = Color.Honeydew;
                    // pictureBox1.BackColor = Color.Black;
                    AdminprintPanel.Controls.Add(pictureBox1);

                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Text = data_base_.MagazineList[(k * 4) + (j - 1)].getName() + "\n" + data_base_.MagazineList[(k * 4) + (j - 1)].type;
                    Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                    lb.Location = labelp;
                    AdminprintPanel.Controls.Add(lb);

                    

                    pictureBox1.Name = "pictureBox" + j + 10;
              
                    lb.Name = "lb" + j;
                    control++;
                    if (control >= data_base_.MagazineList.Count)
                    {
                        break;
                    }

                }


            }
        }

        private void musiccdBtn_Click(object sender, EventArgs e)
        {
            Database data_base_ = Database.get_instance();
            data_base_.MusicCDList.Clear();
            data_base_.read_musiccd("MusicCDTable");
            AdminprintPanel.Controls.Clear();


            int control = 0;
            for (int k = 0; k <= data_base_.MusicCDList.Count / 4; k++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    PictureBox pictureBox1 = new PictureBox();
                    if (k == 0) { pictureBox1.Location = new Point(170 * j, 75); }
                    else { pictureBox1.Location = new Point(170 * j, 350 * k); }

                    pictureBox1.Size = new System.Drawing.Size(170, 200);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + ((k * 4) + j) + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.BackColor = Color.Honeydew;
                    // pictureBox1.BackColor = Color.Black;
                    AdminprintPanel.Controls.Add(pictureBox1);

                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Text = data_base_.MusicCDList[(k * 4) + (j - 1)].getName() + "\n" + data_base_.MusicCDList[(k * 4) + (j - 1)].singer;
                    Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                    lb.Location = labelp;
                    AdminprintPanel.Controls.Add(lb);

                   
                    pictureBox1.Name = "pictureBox" + j + 10;
                  
                    lb.Name = "lb" + j;
                    control++;
                    if (control >= data_base_.MusicCDList.Count)
                    {
                        break;
                    }

                }


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

            Point p = new Point(50, 100);
            dgv.BackgroundColor = Color.Honeydew;
            dgv.Location = p;
            dgv.DataSource = dt;
            dgv.ReadOnly = true;
            AdminprintPanel.Controls.Add(dgv);

        }

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
            int j = database.MusicCDList.Count+ database.BookList.Count;
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
            for(int i = 0; i < database.MagazineList.Count; i++)
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
                   else  if (control == 2)
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
                        MessageBox.Show("user update");
                    }
                    else
                    {
                        MessageBox.Show("user not update");
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
        TextBox AvaiblePasword;
        TextBox NewPassword;
        Label MessageLbl;
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
                        }
                        else
                        {
                            MessageBox.Show("A" +
                                "Password Not Change");
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
                            AdminprintPanel.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            AdminprintPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.BookList[i].getName() + "\n" + database.BookList[i].author;
                            Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                            lb.Location = labelp;
                            AdminprintPanel.Controls.Add(lb);

                       

                            pictureBox1.Name = "pictureBox" + i + 10;
                           
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
                            AdminprintPanel.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            AdminprintPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.BookList[i].getName() + "\n" + database.BookList[i].author;
                            Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                            lb.Location = labelp;
                            AdminprintPanel.Controls.Add(lb);

                         
                            pictureBox1.Name = "pictureBox" + i + 10;
                      
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
                            AdminprintPanel.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            AdminprintPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MagazineList[i].getName() + "\n" + database.MagazineList[i].type;
                            Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                            lb.Location = labelp;
                            AdminprintPanel.Controls.Add(lb);

                           

                            pictureBox1.Name = "pictureBox" + i + 10;
                           
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
                            AdminprintPanel.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170 * i, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\Magazine\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            AdminprintPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MagazineList[i].getName() + "\n" + database.MagazineList[i].type;
                            Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                            lb.Location = labelp;
                            AdminprintPanel.Controls.Add(lb);

                            

                            pictureBox1.Name = "pictureBox" + i + 10;
                         
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
                            AdminprintPanel.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170 * i, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            AdminprintPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MusicCDList[i].getName() + "\n" + database.MusicCDList[i].singer;
                            Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                            lb.Location = labelp;
                            AdminprintPanel.Controls.Add(lb);

                          

                            pictureBox1.Name = "pictureBox" + i + 10;
                            
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
                            AdminprintPanel.Controls.Clear();
                            PictureBox pictureBox1 = new PictureBox();
                            pictureBox1.Location = new Point(170, 100);

                            pictureBox1.Size = new System.Drawing.Size(170, 200);
                            pictureBox1.ImageLocation = Application.StartupPath + @"\MusicCD\" + (i + 1) + ".jpg";
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.BackColor = Color.Honeydew;
                            // pictureBox1.BackColor = Color.Black;
                            AdminprintPanel.Controls.Add(pictureBox1);

                            Label lb = new Label();
                            lb.AutoSize = true;
                            lb.Text = database.MusicCDList[i].getName() + "\n" + database.MusicCDList[i].singer;
                            Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                            lb.Location = labelp;
                            AdminprintPanel.Controls.Add(lb);

                            

                            pictureBox1.Name = "pictureBox" + i + 10;
                            
                            lb.Name = "lb" + i;

                        }
                    }
                }
            }
        }

        private void AdminprintPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
           
            Database data_base_ = Database.get_instance();
            data_base_.BookList.Clear();
            data_base_.read_book("BookTable");

            AdminprintPanel.Controls.Clear();


            int control = 0;
            for (int k = 0; k <= data_base_.BookList.Count / 4; k++)
            {

                for (int j = 1; j <= 4; j++)
                {

                    PictureBox pictureBox1 = new PictureBox();
                    if (k == 0) { pictureBox1.Location = new Point(170 * j, 75); }
                    else { pictureBox1.Location = new Point(170 * j, 350 * k); }

                    pictureBox1.Size = new System.Drawing.Size(170, 200);
                    pictureBox1.ImageLocation = Application.StartupPath + @"\Book\" + ((k * 4) + j) + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox1.BackColor = Color.Honeydew;
                    // pictureBox1.BackColor = Color.Black;
                    AdminprintPanel.Controls.Add(pictureBox1);

                    Label lb = new Label();
                    lb.AutoSize = true;
                    lb.Text = data_base_.BookList[(k * 4) + (j - 1)].getName() + "\n" + data_base_.BookList[(k * 4) + (j - 1)].author;
                    Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                    lb.Location = labelp;
                    AdminprintPanel.Controls.Add(lb);
                    
                    pictureBox1.Name = "pictureBox" + j + 10;
                   
                    lb.Name = "lb" + j;
                    control++;
                    if (control >= data_base_.BookList.Count)
                    {
                        break;
                    }

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
