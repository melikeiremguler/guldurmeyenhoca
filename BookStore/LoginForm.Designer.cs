namespace BookStore
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.exit_lbl = new System.Windows.Forms.Label();
            this.logo_picturebox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.password_txtbox = new System.Windows.Forms.TextBox();
            this.username_txtbox = new System.Windows.Forms.TextBox();
            this.username_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.lbWarring = new System.Windows.Forms.Label();
            this.btnLogup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_lbl.Location = new System.Drawing.Point(278, 2);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(20, 23);
            this.exit_lbl.TabIndex = 8;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.exit_lbl_Click);
            // 
            // logo_picturebox
            // 
            this.logo_picturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logo_picturebox.Image = ((System.Drawing.Image)(resources.GetObject("logo_picturebox.Image")));
            this.logo_picturebox.Location = new System.Drawing.Point(32, 38);
            this.logo_picturebox.Name = "logo_picturebox";
            this.logo_picturebox.Size = new System.Drawing.Size(240, 70);
            this.logo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_picturebox.TabIndex = 0;
            this.logo_picturebox.TabStop = false;
            this.logo_picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.logo_picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.logo_picturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(46, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(48, 307);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 2;
            // 
            // password_txtbox
            // 
            this.password_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.password_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password_txtbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_txtbox.Location = new System.Drawing.Point(48, 284);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.Size = new System.Drawing.Size(213, 19);
            this.password_txtbox.TabIndex = 3;
            // 
            // username_txtbox
            // 
            this.username_txtbox.BackColor = System.Drawing.SystemColors.Control;
            this.username_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username_txtbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_txtbox.Location = new System.Drawing.Point(48, 196);
            this.username_txtbox.Name = "username_txtbox";
            this.username_txtbox.Size = new System.Drawing.Size(213, 19);
            this.username_txtbox.TabIndex = 4;
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.username_lbl.Location = new System.Drawing.Point(43, 178);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(62, 15);
            this.username_lbl.TabIndex = 5;
            this.username_lbl.Text = "Username";
            this.username_lbl.Click += new System.EventHandler(this.username_lbl_Click);
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password_lbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.password_lbl.Location = new System.Drawing.Point(43, 266);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(61, 15);
            this.password_lbl.TabIndex = 6;
            this.password_lbl.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.SkyBlue;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.login_button.Location = new System.Drawing.Point(48, 341);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 31);
            this.login_button.TabIndex = 7;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // lbWarring
            // 
            this.lbWarring.AutoSize = true;
            this.lbWarring.Location = new System.Drawing.Point(29, 402);
            this.lbWarring.Name = "lbWarring";
            this.lbWarring.Size = new System.Drawing.Size(0, 13);
            this.lbWarring.TabIndex = 9;
            // 
            // btnLogup
            // 
            this.btnLogup.BackColor = System.Drawing.Color.SkyBlue;
            this.btnLogup.FlatAppearance.BorderSize = 0;
            this.btnLogup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogup.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogup.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogup.Location = new System.Drawing.Point(161, 341);
            this.btnLogup.Name = "btnLogup";
            this.btnLogup.Size = new System.Drawing.Size(100, 31);
            this.btnLogup.TabIndex = 10;
            this.btnLogup.Text = "Log Up";
            this.btnLogup.UseVisualStyleBackColor = false;
            this.btnLogup.Click += new System.EventHandler(this.btnLogup_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.btnLogup);
            this.Controls.Add(this.lbWarring);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.logo_picturebox);
            this.Controls.Add(this.password_lbl);
            this.Controls.Add(this.username_lbl);
            this.Controls.Add(this.username_txtbox);
            this.Controls.Add(this.password_txtbox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox password_txtbox;
        private System.Windows.Forms.TextBox username_txtbox;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.PictureBox logo_picturebox;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label lbWarring;
        private System.Windows.Forms.Button btnLogup;
    }
}