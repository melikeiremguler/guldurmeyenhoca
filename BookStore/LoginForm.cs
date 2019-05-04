﻿using System;
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
    public partial class LoginForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        CustomerForm ths;
        AdminForm adf;
        public static int current_customer_id = -1;
        public LoginForm(CustomerForm frm)
        {
            InitializeComponent();
            ths = frm; //customer formundaki toolları kullanmamızı sağlar.
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        public void login_button_Click(object sender, EventArgs e)
        {
            if(User_control())
            {
                if(username_txtbox.Text == "tiv")
                {
                    ths.Visible = false;
                    adf = new AdminForm();
                    adf.Show();
                    this.Close();
                    
                }
                else
                {
                    ths.chancePasswordBtn.Visible = true;
                    
                    ths.SettingBtn.Visible = true;
                    ths.btnLogin.Text = "LOGOUT"; //customer adı login buttonuna eklenir 
                    ths.lbHosgeldin.Text = "HOŞGELDİN";
                    ths.lbUserName.Text = username_txtbox.Text.ToUpper();
                    clean_unknownuser_shoppingcart();
                    ths.read_shopping_cart();
                    ShoppingCart shopping_cart = new ShoppingCart(current_customer_id, ref ths.shopping_cart_list, 1);
                    ths.total_quantity = shopping_cart.getTotalProduct();
                    ths.numberofproduct.Text = shopping_cart.getTotalProduct().ToString();
                }
               
            }
            else
            {
                lbWarring.ForeColor = Color.Red;
                lbWarring.Text = "YOUR PASSWORD/USERNAME IS WRONG";
            }
           
        }
        public bool User_control()
        {

            Database data_base_ = Database.get_instance();
            data_base_.CustomerList.Clear();
            data_base_.read_customer("UserTable");

            string password;
            password = password_txtbox.Text;
            if (username_txtbox.Text != "tiv")
            {
                HashCode hash = new HashCode(password_txtbox.Text);
                password = hash.hashCode; //Hashlendi

            }
            for (int i = 0; i < data_base_.CustomerList.Count; i++)
            {
                if (username_txtbox.Text.Equals(data_base_.CustomerList[i].userName) && password.Equals(data_base_.CustomerList[i].password))
                {
                    current_customer_id = data_base_.CustomerList[i].customerID;
                    return true;
                }

            }
            return false;

        }

        private void clean_unknownuser_shoppingcart()
        {
            ths.read_shopping_cart();
            ShoppingCart shopping_cart = new ShoppingCart(-1, ref ths.shopping_cart_list, 1);
            for (int i = 0; i < ths.shopping_cart_list.Count; i++)
            {

                ItemToPurchase item = (ItemToPurchase)ths.shopping_cart_list[i];

                if (item.product.getId() == -1)
                {
                    shopping_cart.removeProduct(item);
                    i--;
                }
            }
            if (ths.shoppingcart_datagridview != null)
            {
                ths.shoppingcart_datagridview.ClearSelection();
                ths.shoppingcart_datagridview.Update();
                ths.shoppingcart_datagridview.Refresh();
            }

            this.Close();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogup_Click(object sender, EventArgs e)
        {
            LogUpForm logUpForm = new LogUpForm();
            logUpForm.Show();   

        }
    }
}
