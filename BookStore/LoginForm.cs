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

        public LoginForm()
        {
            InitializeComponent();
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

        private void login_button_Click(object sender, EventArgs e)
        {
            Program.call_Main(true);
            this.Close();
        }
    }
}
