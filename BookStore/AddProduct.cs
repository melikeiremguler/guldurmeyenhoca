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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {          
        
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
        }
        //AdminUser admin = new AdminUser(null,null,null,null, null,null);
        private void btnBookAdd_Click(object sender, EventArgs e)
        {

           
            Double price = (Double)Int32.Parse(txtPrice.Text);
            int ISBN = Int32.Parse(txtIsbn.Text);
            int page = Int32.Parse(txtPage.Text);
          //  admin.addNewBook(0, txtName.Text, price, pcbImage.Image, ISBN, txtAuther.Text, txtPublisher.Text, page);

            
        }
     

        private void btnMagAdd_Click(object sender, EventArgs e)
        {
            string typ = cmbMagTyp.SelectedItem.ToString();
            Double price = (Double)Int32.Parse(txtPrice.Text);
         //  admin.addNewMag(0, txtName.Text, price, pcbImage.Image, Magazine.Type, txtIssue.Text);
          
        }

        private void btnMucAdd_Click(object sender, EventArgs e)
        {
            string typ = cmbMucTyp.SelectedItem.ToString();
            Double price = (Double)Int32.Parse(txtPrice.Text);
            //  admin.addNewMag(0, txtName.Text, price, pcbImage.Image, Magazine.Type, txtIssue.Text);


        }
    }
}
