namespace BookStore
{
    partial class CustomerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.lbFilter = new System.Windows.Forms.Label();
            this.lbPruduct = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.reklam1picturebox = new System.Windows.Forms.PictureBox();
            this.reklam2picturebox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customerpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbHosgeldin = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.magazineBtn = new System.Windows.Forms.Button();
            this.musiccdBtn = new System.Windows.Forms.Button();
            this.cartBtn = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.creditcardBtn = new System.Windows.Forms.Button();
            this.chancePasswordBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).BeginInit();
            this.customerpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.BackColor = System.Drawing.Color.SeaShell;
            this.lbFilter.Location = new System.Drawing.Point(10, 77);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(29, 13);
            this.lbFilter.TabIndex = 11;
            this.lbFilter.Text = "Filter";
            // 
            // lbPruduct
            // 
            this.lbPruduct.AutoSize = true;
            this.lbPruduct.BackColor = System.Drawing.Color.SeaShell;
            this.lbPruduct.Location = new System.Drawing.Point(10, 50);
            this.lbPruduct.Name = "lbPruduct";
            this.lbPruduct.Size = new System.Drawing.Size(44, 13);
            this.lbPruduct.TabIndex = 10;
            this.lbPruduct.Text = "Product";
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(75, 69);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(109, 21);
            this.cmbFiltre.TabIndex = 9;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "BOOK",
            "MAGAZİNE",
            "MUSİC CD"});
            this.cmbProduct.Location = new System.Drawing.Point(75, 42);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(109, 21);
            this.cmbProduct.TabIndex = 8;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // searchgroupBox
            // 
            this.searchgroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchgroupBox.Controls.Add(this.searchBtn);
            this.searchgroupBox.Controls.Add(this.textBox1);
            this.searchgroupBox.Controls.Add(this.lbFilter);
            this.searchgroupBox.Controls.Add(this.lbPruduct);
            this.searchgroupBox.Controls.Add(this.cmbFiltre);
            this.searchgroupBox.Controls.Add(this.cmbProduct);
            this.searchgroupBox.Location = new System.Drawing.Point(2, 152);
            this.searchgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchgroupBox.Name = "searchgroupBox";
            this.searchgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchgroupBox.Size = new System.Drawing.Size(189, 123);
            this.searchgroupBox.TabIndex = 12;
            this.searchgroupBox.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(99, 95);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(56, 19);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 15;
            // 
            // reklam1picturebox
            // 
            this.reklam1picturebox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reklam1picturebox.Location = new System.Drawing.Point(0, 275);
            this.reklam1picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.reklam1picturebox.Name = "reklam1picturebox";
            this.reklam1picturebox.Size = new System.Drawing.Size(191, 187);
            this.reklam1picturebox.TabIndex = 13;
            this.reklam1picturebox.TabStop = false;
            this.reklam1picturebox.Click += new System.EventHandler(this.reklam1picturebox_Click);
            // 
            // reklam2picturebox
            // 
            this.reklam2picturebox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reklam2picturebox.Location = new System.Drawing.Point(-1, 466);
            this.reklam2picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.reklam2picturebox.Name = "reklam2picturebox";
            this.reklam2picturebox.Size = new System.Drawing.Size(191, 187);
            this.reklam2picturebox.TabIndex = 14;
            this.reklam2picturebox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // customerpanel
            // 
            this.customerpanel.AutoSize = true;
            this.customerpanel.BackColor = System.Drawing.Color.Honeydew;
            this.customerpanel.Controls.Add(this.panel1);
            this.customerpanel.Controls.Add(this.searchgroupBox);
            this.customerpanel.Controls.Add(this.panel2);
            this.customerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerpanel.Location = new System.Drawing.Point(0, 0);
            this.customerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(1022, 609);
            this.customerpanel.TabIndex = 7;
            this.customerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerpanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbHosgeldin);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.bookBtn);
            this.panel1.Controls.Add(this.magazineBtn);
            this.panel1.Controls.Add(this.musiccdBtn);
            this.panel1.Controls.Add(this.cartBtn);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.creditcardBtn);
            this.panel1.Controls.Add(this.chancePasswordBtn);
            this.panel1.Controls.Add(this.SettingBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1015, 144);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserName.Location = new System.Drawing.Point(889, 83);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 13);
            this.lbUserName.TabIndex = 24;
            // 
            // lbHosgeldin
            // 
            this.lbHosgeldin.AutoSize = true;
            this.lbHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHosgeldin.Location = new System.Drawing.Point(889, 51);
            this.lbHosgeldin.Name = "lbHosgeldin";
            this.lbHosgeldin.Size = new System.Drawing.Size(0, 18);
            this.lbHosgeldin.TabIndex = 23;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBtn.Location = new System.Drawing.Point(2, 8);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(92, 123);
            this.HomeBtn.TabIndex = 14;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // bookBtn
            // 
            this.bookBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bookBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookBtn.BackgroundImage")));
            this.bookBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bookBtn.Location = new System.Drawing.Point(98, 8);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(92, 123);
            this.bookBtn.TabIndex = 15;
            this.bookBtn.Text = "BOOK";
            this.bookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // magazineBtn
            // 
            this.magazineBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.magazineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("magazineBtn.BackgroundImage")));
            this.magazineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.magazineBtn.Location = new System.Drawing.Point(191, 8);
            this.magazineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.magazineBtn.Name = "magazineBtn";
            this.magazineBtn.Size = new System.Drawing.Size(92, 123);
            this.magazineBtn.TabIndex = 16;
            this.magazineBtn.Text = "MAGAZINE";
            this.magazineBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.magazineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.magazineBtn.UseVisualStyleBackColor = false;
            this.magazineBtn.Click += new System.EventHandler(this.magazineBtn_Click);
            // 
            // musiccdBtn
            // 
            this.musiccdBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.musiccdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musiccdBtn.BackgroundImage")));
            this.musiccdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musiccdBtn.Location = new System.Drawing.Point(287, 8);
            this.musiccdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.musiccdBtn.Name = "musiccdBtn";
            this.musiccdBtn.Size = new System.Drawing.Size(92, 123);
            this.musiccdBtn.TabIndex = 17;
            this.musiccdBtn.Text = "MUSIC CD";
            this.musiccdBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musiccdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.musiccdBtn.UseVisualStyleBackColor = false;
            this.musiccdBtn.Click += new System.EventHandler(this.musiccdBtn_Click);
            // 
            // cartBtn
            // 
            this.cartBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cartBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cartBtn.BackgroundImage")));
            this.cartBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cartBtn.Location = new System.Drawing.Point(383, 8);
            this.cartBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cartBtn.Name = "cartBtn";
            this.cartBtn.Size = new System.Drawing.Size(92, 123);
            this.cartBtn.TabIndex = 21;
            this.cartBtn.Text = "CART";
            this.cartBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cartBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.cartBtn.UseVisualStyleBackColor = false;
            this.cartBtn.Click += new System.EventHandler(this.cartBtn_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Location = new System.Drawing.Point(479, 8);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 123);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // creditcardBtn
            // 
            this.creditcardBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.creditcardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creditcardBtn.BackgroundImage")));
            this.creditcardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.creditcardBtn.Location = new System.Drawing.Point(575, 8);
            this.creditcardBtn.Margin = new System.Windows.Forms.Padding(2);
            this.creditcardBtn.Name = "creditcardBtn";
            this.creditcardBtn.Size = new System.Drawing.Size(92, 123);
            this.creditcardBtn.TabIndex = 20;
            this.creditcardBtn.Text = "CREDIT CARD";
            this.creditcardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.creditcardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.creditcardBtn.UseVisualStyleBackColor = false;
            this.creditcardBtn.Visible = false;
            // 
            // chancePasswordBtn
            // 
            this.chancePasswordBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chancePasswordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chancePasswordBtn.BackgroundImage")));
            this.chancePasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chancePasswordBtn.Location = new System.Drawing.Point(671, 8);
            this.chancePasswordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chancePasswordBtn.Name = "chancePasswordBtn";
            this.chancePasswordBtn.Size = new System.Drawing.Size(92, 123);
            this.chancePasswordBtn.TabIndex = 19;
            this.chancePasswordBtn.Text = "CHANGE PASSWORD";
            this.chancePasswordBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chancePasswordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chancePasswordBtn.UseVisualStyleBackColor = false;
            this.chancePasswordBtn.Visible = false;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingBtn.BackgroundImage")));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingBtn.Location = new System.Drawing.Point(767, 8);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(92, 123);
            this.SettingBtn.TabIndex = 18;
            this.SettingBtn.Text = "SETTINGS";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(195, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 425);
            this.panel2.TabIndex = 13;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1022, 609);
            this.Controls.Add(this.reklam2picturebox);
            this.Controls.Add(this.reklam1picturebox);
            this.Controls.Add(this.customerpanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).EndInit();
            this.customerpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbPruduct;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.GroupBox searchgroupBox;
        private System.Windows.Forms.PictureBox reklam1picturebox;
        private System.Windows.Forms.PictureBox reklam2picturebox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel customerpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button magazineBtn;
        private System.Windows.Forms.Button musiccdBtn;
        private System.Windows.Forms.Button cartBtn;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button creditcardBtn;
        public System.Windows.Forms.Button chancePasswordBtn;
        public System.Windows.Forms.Button SettingBtn;
        public System.Windows.Forms.Label lbHosgeldin;
        public System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Panel panel2;
    }
}