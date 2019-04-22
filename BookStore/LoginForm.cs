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
    public partial class LoginForm : Form
    {

        private bool mouseDown;
        private Point lastLocation;
        CustomerForm ths;
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

        private void username_lbl_Click(object sender, EventArgs e)
        {

        }

        public void login_button_Click(object sender, EventArgs e)
        {
            if(user_control())
            {
                ths.chancePasswordBtn.Visible = true;
                ths.creditcardBtn.Visible = true;
                ths.SettingBtn.Visible = true;
                ths.btnLogin.Text ="LOGOUT"; //customer adı login buttonuna eklenir 
                ths.lbHosgeldin.Text = "HOŞGELDİN";
                ths.lbUserName.Text = username_txtbox.Text.ToUpper();
                this.Close();
            }
            else
            {
                lbWarring.ForeColor = Color.Red;
                lbWarring.Text = "YOUR POSSWORD/USERNAME IS WRONG";
            }
           
        }
        public bool user_control()
        {
            if (username_txtbox.Text == "tiv" && password_txtbox.Text == "tiv")
            {

                return true;

            }
            else
            {
               
                return false;
            }
        }

       
    }
}
