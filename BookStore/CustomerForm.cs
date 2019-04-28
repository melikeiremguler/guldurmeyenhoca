using System;
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
        private ArrayList shopping_cart_list;
        private DataGridView shoppingcart_datagridview;
        private TextBox total_price_textbox;
        private Label total_price_label;
        private Button buy_button;
        private ContextMenuStrip contextmenu;

        public CustomerForm()
        {
            InitializeComponent();
            shopping_cart_list = new ArrayList();
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
<<<<<<< HEAD
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



=======
                lb.Text = data_base_.BookList[j - 1].getName();
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi_Book;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;
                lb.Name = "lb" + j;
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

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

<<<<<<< HEAD
            CustomerForm_Load(sender, e);
=======

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
                lb.Text = data_base_.BookList[j - 1].getName();
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi_Book;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;
                lb.Name = "lb" + j;

            }
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

        }

        public void read_shopping_cart()
        {
            Database database_obj = Database.get_instance();
            using (SQLiteConnection connection = new SQLiteConnection("Data Source=" + Application.StartupPath + "\\BookStore.db;Version=3"))
            {
                connection.Open();
                string stm = "SELECT * FROM ShoppingCartTable";
                using (SQLiteCommand sql_command = new SQLiteCommand(stm, connection))
                {
                    using (SQLiteDataReader sdr = sql_command.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            ItemToPurchase item = new ItemToPurchase(new Product(sdr.GetInt32(0), sdr.GetString(1), sdr.GetDouble(3), sdr.GetString(4)), sdr.GetInt32(2));
                            shopping_cart_list.Add(item);

                        }
                        sdr.Close();
                        connection.Close();
                    }
                }
                connection.Close();
            }

        }

        public void yeniolusturulanButonlarinClickOlayi_Book(object sender, EventArgs e)
        {
<<<<<<< HEAD
            PictureBox tıklananPictureNesnesi = (sender as PictureBox);
=======

            read_shopping_cart();
            Database database_obj = Database.get_instance();
            Button tıklananButtonNesnesi = (sender as Button);
            Product book_obj = null;


            database_obj.read_book("BookTable");
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

            string picture_name = tıklananPictureNesnesi.Name;
            string temp = picture_name.Remove(0, 3);
            string label_name = "lb" + temp;

            //to call related label
            Control label = this.Controls.Find(label_name, true).FirstOrDefault() as Label;
<<<<<<< HEAD

            if (label != null)
            {

=======
            if (label != null)
            {

                for (int i = 0; i < database_obj.BookList.Count; i++)
                {

                    if (label.Text.Equals(database_obj.BookList[i].getName()))
                    {
                        book_obj = database_obj.BookList[i];
                        break;
                    }

                }
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754
            }

            ItemToPurchase item_to_purchase = new ItemToPurchase(book_obj, 1);
            ShoppingCart shopping_cart = new ShoppingCart(LoginForm.current_customer_id, ref shopping_cart_list, 1);
            shopping_cart.addProduct(item_to_purchase);



        }

        public void yeniolusturulanButonlarinClickOlayi_MusicCD(object sender, EventArgs e)
        {
            read_shopping_cart();
            Database database_obj = Database.get_instance();
            Button tıklananButtonNesnesi = (sender as Button);
            Product musiccd_obj = null;


            database_obj.read_musiccd("MusicCDTable");

            string button_name = tıklananButtonNesnesi.Name;
            string temp = button_name.Remove(0, 3);
            string label_name = "lb" + temp;

            //to call related label
            Control label = this.Controls.Find(label_name, true).FirstOrDefault() as Label;

            if (label != null)
            {

                for (int i = 0; i < database_obj.MusicCDList.Count; i++)
                {

                    if (label.Text.Equals(database_obj.MusicCDList[i].getName()))
                    {
                        musiccd_obj = database_obj.MusicCDList[i];
                        break;
                    }

                }
            }

            ItemToPurchase item_to_purchase = new ItemToPurchase(musiccd_obj, 1);
            ShoppingCart shopping_cart = new ShoppingCart(LoginForm.current_customer_id, ref shopping_cart_list, 1);
            shopping_cart.addProduct(item_to_purchase);



        }

        public void yeniolusturulanButonlarinClickOlayi_Magazine(object sender, EventArgs e)
        {
            read_shopping_cart();
            Database database_obj = Database.get_instance();
            Button tıklananButtonNesnesi = (sender as Button);
            Product magazine_obj = null;


            database_obj.read_magazine("MagazineTable");

            string button_name = tıklananButtonNesnesi.Name;
            string temp = button_name.Remove(0, 3);
            string label_name = "lb" + temp;

            //to call related label
            Control label = this.Controls.Find(label_name, true).FirstOrDefault() as Label;

            if (label != null)
            {

                for (int i = 0; i < database_obj.MagazineList.Count; i++)
                {

                    if (label.Text.Equals(database_obj.MagazineList[i].getName()))
                    {
                        magazine_obj = database_obj.MagazineList[i];
                        break;
                    }

                }
            }

            ItemToPurchase item_to_purchase = new ItemToPurchase(magazine_obj, 1);
            ShoppingCart shopping_cart = new ShoppingCart(LoginForm.current_customer_id, ref shopping_cart_list, 1);
            shopping_cart.addProduct(item_to_purchase);

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            CustomerForm_Load(sender, e);
=======


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
                lb.Text = data_base_.BookList[j - 1].getName();
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);


                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi_Book;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;
                lb.Name = "lb" + j;

            }

>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

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
<<<<<<< HEAD
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


=======
                lb.Text = data_base_.MagazineList[j - 1].getName();
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi_Magazine;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;
                lb.Name = "lb" + j;
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

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
<<<<<<< HEAD
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

=======
                lb.Text = data_base_.MusicCDList[j - 1].getName();
                Point labelp = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 210);
                lb.Location = labelp;
                panel2.Controls.Add(lb);

                Button btn = new Button();
                btn.Text = "SEPETE EKLE";
                btn.Size = new Size(100, 70);
                btn.Location = new Point(pictureBox1.Location.X + pictureBox1.Width / 10, pictureBox1.Location.Y + 245);
                btn.Click += yeniolusturulanButonlarinClickOlayi_MusicCD;
                btn.BackColor = Color.DarkSeaGreen;
                panel2.Controls.Add(btn);

                pictureBox1.Name = "pictureBox" + j + 10;
                btn.Name = "btn" + j;
                lb.Name = "lb" + j;
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

            }
        }

        private void customerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

<<<<<<< HEAD
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
=======
        private void cartBtn_Click(object sender, EventArgs e)
        {
            double total_Price = 0.0;
            shopping_cart_list.Clear();
            read_shopping_cart();
            panel2.Controls.Clear();

            //to populate datagridview
            shoppingcart_datagridview = new DataGridView();
            shoppingcart_datagridview.Location = new Point(8, 8);
            shoppingcart_datagridview.Size = new Size(800, 350);
            shoppingcart_datagridview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            shoppingcart_datagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            shoppingcart_datagridview.CellBorderStyle = DataGridViewCellBorderStyle.Single;


            DataGridViewImageColumn img_column = new DataGridViewImageColumn();
            img_column.HeaderText = "Photo";
            img_column.Name = "Photo";
            shoppingcart_datagridview.Columns.Add(img_column);
            shoppingcart_datagridview.ColumnCount = 4;
            shoppingcart_datagridview.Columns[1].Name = "Name";
            shoppingcart_datagridview.Columns[1].Width = 220;
            shoppingcart_datagridview.Columns[2].Name = "Quantity";
            shoppingcart_datagridview.Columns[2].Width = 220;
            shoppingcart_datagridview.Columns[3].Name = "Price";
            shoppingcart_datagridview.Columns[3].Width = 220;
            shoppingcart_datagridview.MouseDown += new MouseEventHandler(shoppingcart_datagridview_mouseDown);

            for (int i = 0; i < shopping_cart_list.Count; i++)
            {

                ItemToPurchase item = (ItemToPurchase)shopping_cart_list[i];
                if (item.product.getId() == LoginForm.current_customer_id)
                {
                    string[] path = item.product.image_path.Split(',');
                    Image img = Image.FromFile(Application.StartupPath + @"\" + path[0] + @"\" + path[1] + ".jpg");
                    Image thumb = img.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                    total_Price += item.product.getPrice();

                    Object[] row = new Object[] { thumb, item.product.getName(), item.quantity, item.product.getPrice() };
                    shoppingcart_datagridview.Rows.Add(row);
                }
            }

            //to populate label 
            total_price_label = new Label();
            total_price_label.Name = "totalPrice_lbl";
            total_price_label.Text = "Total Price : ";
            total_price_label.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            total_price_label.Location = new Point(8, 380);
            total_price_label.Width = 100;
            total_price_label.Height = 40;

            //to populate total price textbox 
            total_price_textbox = new TextBox();
            total_price_textbox.Name = "totalPrice_txtbox";
            total_price_textbox.Text = total_Price.ToString();
            total_price_textbox.Location = new Point(110, 380);
            total_price_textbox.Width = 150;
            total_price_textbox.Height = 40;
            total_price_textbox.Enabled = false;

            //to populate buy button
            buy_button = new Button();
            buy_button.Name = "totalPrice_button";
            buy_button.Text = "Buy";
            buy_button.BackColor = Color.FromArgb(143, 188, 139);
            buy_button.Location = new Point(600, 380);
            buy_button.Width = 150;
            buy_button.Height = 30;
            buy_button.Click += buy_button_Click;

            panel2.Controls.Add(total_price_label);
            panel2.Controls.Add(total_price_textbox);
            panel2.Controls.Add(buy_button);
            panel2.Controls.Add(shoppingcart_datagridview);
        }

        private void shoppingcart_datagridview_mouseDown(Object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextmenu = new ContextMenuStrip();
                int position_xy_mouse_row = shoppingcart_datagridview.HitTest(e.X, e.Y).RowIndex;

                if (position_xy_mouse_row >= 0)
                {
                    contextmenu.Items.Add("Delete").Name = "Del";
                    shoppingcart_datagridview.ClearSelection();
                    shoppingcart_datagridview.Rows[position_xy_mouse_row].Selected = true;
                    contextmenu.Show(shoppingcart_datagridview, new Point(e.X, e.Y));
                    contextmenu.Click += new EventHandler(DeleteRow_Click);
                    
                }
               
            }

        }

        //to delete product in shoppingcart 
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            contextmenu.Hide();
            ShoppingCart shopping_cart = new ShoppingCart(LoginForm.current_customer_id, ref shopping_cart_list, 1);
            DialogResult confirm_question = MessageBox.Show("Would you like to delete te product?",
                                                   "The Confirmation",
                                 MessageBoxButtons.YesNoCancel,
                                 MessageBoxIcon.Question);

            if (confirm_question == DialogResult.Yes)
            {

                try
                {
                    Int32 rowToDelete = shoppingcart_datagridview.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                    for (int i = 0; i < shopping_cart_list.Count; i++)
                    {

                        ItemToPurchase item = (ItemToPurchase)shopping_cart_list[i];

                        if (item.product.getId() == LoginForm.current_customer_id &&
                            shoppingcart_datagridview.Rows[rowToDelete].Cells[1].Value.ToString().Equals(item.product.getName()))
                        {
                            shopping_cart.removeProduct(item);
                            shopping_cart_list.RemoveAt(i);
                            break;
                        }
                    }

                    shoppingcart_datagridview.Rows.RemoveAt(rowToDelete);
                    shoppingcart_datagridview.ClearSelection();
                }catch
                {
                    MessageBox.Show("Error! You can't delete it.", "Warning",
                                     MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            ShoppingCart shopping_cart = new ShoppingCart(LoginForm.current_customer_id, ref shopping_cart_list, 1);
            DialogResult confirm_question = MessageBox.Show("Would you like to buy it?",
                                                    "The Confirmation",
                                  MessageBoxButtons.YesNoCancel,
                                  MessageBoxIcon.Question);

            if (confirm_question == DialogResult.Yes)
            {
                for (int i = 0; i < shopping_cart_list.Count; i++)
                {

                    ItemToPurchase item = (ItemToPurchase)shopping_cart_list[i];
                    if (item.product.getId() == LoginForm.current_customer_id)
                    {
                        shopping_cart.removeProduct(item);
                    }
                }

                shopping_cart_list.Clear();

                shoppingcart_datagridview.Rows.Clear();
                shoppingcart_datagridview.Refresh();
                total_price_textbox.Text = "0";
            }

>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

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
