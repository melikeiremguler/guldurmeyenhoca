using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        string file;
        Database database = Database.get_instance();
        AdminUser admin = AdminUser.get_instance();
        private void AddProduct_Load(object sender, EventArgs e)
        {
            database.BookList = database.read_book("BookTable");
            database.MagazineList = database.read_magazine("MagazineTable");
            database.MusicCDList = database.read_musiccd("MusicCDTable");

            cmbMagTyp.Items.Add(Magazine.Type.Actual);
            cmbMagTyp.Items.Add(Magazine.Type.Computer);
            cmbMagTyp.Items.Add(Magazine.Type.News);
            cmbMagTyp.Items.Add(Magazine.Type.Sport);
            cmbMagTyp.Items.Add(Magazine.Type.Technology);

            cmbMucTyp.Items.Add(MusicCD.Type.Country);
            cmbMucTyp.Items.Add(MusicCD.Type.HardRock);
            cmbMucTyp.Items.Add(MusicCD.Type.Romance);

        }
      
        
        private void rdbBookAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtIssue.Enabled = false;
            txtSinger.Enabled = false;
            cmbMagTyp.Enabled = false;
            cmbMucTyp.Enabled = false;
            txtPublisher.Enabled = true;
            txtPage.Enabled = true;
            txtIsbn.Enabled = true;
            txtAuther.Enabled = true;
            btnBookAdd.Visible = true;
            btnMagAdd.Visible = false;
            btnMucAdd.Visible = false;
            txtDescription.Enabled = true;
            btnLoad.Enabled = false;
        }

        private void rdbMagAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtIssue.Enabled = true;
            txtSinger.Enabled = false;
            cmbMagTyp.Enabled = true;
            cmbMucTyp.Enabled = false;
            txtPublisher.Enabled = false;
            txtPage.Enabled = false;
            txtIsbn.Enabled = false;
            txtAuther.Enabled = false;
            btnBookAdd.Visible = false;
            btnMagAdd.Visible = true;
            btnMucAdd.Visible = false;
            txtDescription.Enabled = true;
            btnLoad.Enabled = false;
        }

        private void rdbMucAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtIssue.Enabled = false;
            txtSinger.Enabled = true;
            cmbMagTyp.Enabled = false;
            cmbMucTyp.Enabled = true;
            txtPublisher.Enabled = false;
            txtPage.Enabled = false;
            txtIsbn.Enabled = false;
            txtAuther.Enabled = false;
            btnBookAdd.Visible = false;
            btnMagAdd.Visible = false;
            btnMucAdd.Visible = true;
            txtDescription.Enabled = false;
            btnLoad.Enabled = true;
        }
      
        private void btnBookAdd_Click(object sender, EventArgs e)
        {

            string filename = Application.StartupPath + @"\Book\" + (database.BookList.Count +1)+ ".jpg";

            using (FileStream fstream = new FileStream(filename, FileMode.Create))
            {
                pcbImage.Image.Save(fstream, ImageFormat.Jpeg);
                fstream.Close();
            }
            Double price = Double.Parse(txtPrice.Text);
            int ISBN = Int32.Parse(txtIsbn.Text);
            int page = Int32.Parse(txtPage.Text);
            admin.addNewBook((database.BookList.Count+1), txtName.Text, price, null, ISBN, txtAuther.Text, txtPublisher.Text, page, txtDescription.Text, Convert.ToInt32(StockTxt.Text));
            MessageBox.Show("Succes");

        }


        private void btnMagAdd_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\Magazine\" + (database.MagazineList.Count+1) + ".jpg";
           

            using (FileStream fstream = new FileStream(filename, FileMode.Create))
            {
                pcbImage.Image.Save(fstream, ImageFormat.Jpeg);
                fstream.Close();
            }

            Magazine.Type typ = (Magazine.Type)cmbMagTyp.SelectedItem;
            Double price = Double.Parse(txtPrice.Text);
            admin.addNewMagazine((database.MagazineList.Count+1), txtName.Text, price, null, typ, txtIssue.Text, txtDescription.Text, Convert.ToInt32(StockTxt.Text));
            MessageBox.Show("Succes");
        }

        private void btnMucAdd_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\MusicCD\" +( database.MusicCDList.Count+1) + ".jpg";
            string Filemusic = Application.StartupPath + @"\Demos\" + (database.MusicCDList.Count+1) + ".wav";
            File.Copy(file, Filemusic);

            using (FileStream fstream = new FileStream(filename, FileMode.Create))
            {
                pcbImage.Image.Save(fstream, ImageFormat.Jpeg);
                fstream.Close();
            }
            MusicCD.Type typ = (MusicCD.Type)cmbMucTyp.SelectedItem; //Type tipine çevrildi
            Double price = Double.Parse(txtPrice.Text);   //price double'a çevrildi
            admin.addNewMusicCD((database.MusicCDList.Count+1), txtName.Text, price, null, txtSinger.Text, typ, Convert.ToInt32(StockTxt.Text));
            MessageBox.Show("Succes");

        }

        private void btnDowload_Click(object sender, EventArgs e)
        {
            Image File;
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "Image files (*.jpg, *.png) | *.jpg; *.png";

            if (f.ShowDialog() == DialogResult.OK)
            {
                File = Image.FromFile(f.FileName);
                pcbImage.Image = File;
                pcbImage.Image = resizeImage(pcbImage.Image, new Size(120, 120));
            }
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
           
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Music files (*.wav) | *.wav";

            if(dialog.ShowDialog()==DialogResult.OK)
            {
                 file = dialog.FileName;
                 lbSuc.Text = file;
            }
            

        }
    }
}
