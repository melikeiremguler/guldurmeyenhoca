﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    /*! \class LogUpForm
     *  \brief It is Form class.
     *  \details it is derived from Form class
     */
    public partial class LogUpForm : Form
    {
        public LogUpForm()
        {
            InitializeComponent();
        }

        /*! \fn void btnLogUp_Click(object sender, EventArgs e)
         *  \brief A click listener function.
         *  \details It is used to sign up by customer.
         *  \param sender it is an object
         *  \param e it is an EventArgs
         *  \return void
        */
        private void btnLogUp_Click(object sender, EventArgs e)
        {

            int flag = 1;
            if ((txtName.Text == "") || (txtEmail.Text == "") || (txtPassword.Text == "") || (txtUserName.Text == "") || (txtAddress.Text == ""))
            {
                lbWarning.Text = "you cannot leave this field blank";
                flag = 0;

            }
            else
            {
                lbWarning.Text = "";
                flag++;
            }
            HashCode hash = new HashCode(txtPassword.Text);
            string password = hash.hashCode;



            Database database = Database.get_instance();
            List<Customer> customers = database.read_customer("UserTable");
            for (int i = 0; i < customers.Count; i++)
            {
                if (txtUserName.Text == customers[i].userName)
                {
                    lbUserNWarning.Text = "this username is in use";
                    flag = 0;
                    break;
                }
                else
                {

                    lbUserNWarning.Text = "";
                }
            }
            if (flag != 0)
            {
                Customer customer = new Customer(customers[customers.Count - 1].customerID + 1, txtName.Text, txtEmail.Text, txtUserName.Text, password, txtAddress.Text);

                string sql_statement = "INSERT INTO UserTable(Name,Email,Username,Password,Address) values(@Name,@Email,@Username,@Password,@Address)";
                database.add_customer(sql_statement, customer);
                MessageBox.Show("successful");
                this.Close();


            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
          //  e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

    }
}
