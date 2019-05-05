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
            this.reklam1picturebox = new System.Windows.Forms.PictureBox();
            this.reklam2picturebox = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.lbPruduct = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numberofproduct = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbHosgeldin = new System.Windows.Forms.Label();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.magazineBtn = new System.Windows.Forms.Button();
            this.musiccdBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chancePasswordBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.SearchReklamPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).BeginInit();
            this.searchgroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SearchReklamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // reklam1picturebox
            // 
            this.reklam1picturebox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reklam1picturebox.Location = new System.Drawing.Point(0, 126);
            this.reklam1picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.reklam1picturebox.Name = "reklam1picturebox";
            this.reklam1picturebox.Size = new System.Drawing.Size(191, 187);
            this.reklam1picturebox.TabIndex = 13;
            this.reklam1picturebox.TabStop = false;
         
            // 
            // reklam2picturebox
            // 
            this.reklam2picturebox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reklam2picturebox.Location = new System.Drawing.Point(0, 316);
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
            // searchgroupBox
            // 
            this.searchgroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.searchgroupBox.Controls.Add(this.searchBtn);
            this.searchgroupBox.Controls.Add(this.Searchtxt);
            this.searchgroupBox.Controls.Add(this.lbFilter);
            this.searchgroupBox.Controls.Add(this.lbPruduct);
            this.searchgroupBox.Controls.Add(this.cmbFiltre);
            this.searchgroupBox.Controls.Add(this.cmbProduct);
            this.searchgroupBox.Location = new System.Drawing.Point(2, 0);
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
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Searchtxt
            // 
            this.Searchtxt.Location = new System.Drawing.Point(9, 17);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(176, 20);
            this.Searchtxt.TabIndex = 15;
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
            this.cmbFiltre.Text = "Select";
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
            this.cmbProduct.Text = "Select";
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.numberofproduct);
            this.panel1.Controls.Add(this.lbUserName);
            this.panel1.Controls.Add(this.lbHosgeldin);
            this.panel1.Controls.Add(this.HomeBtn);
            this.panel1.Controls.Add(this.bookBtn);
            this.panel1.Controls.Add(this.magazineBtn);
            this.panel1.Controls.Add(this.musiccdBtn);
            this.panel1.Controls.Add(this.billBtn);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.chancePasswordBtn);
            this.panel1.Controls.Add(this.SettingBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 219);
            this.panel1.TabIndex = 0;
            // 
            // numberofproduct
            // 
            this.numberofproduct.AutoSize = true;
            this.numberofproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.numberofproduct.Location = new System.Drawing.Point(408, 113);
            this.numberofproduct.Name = "numberofproduct";
            this.numberofproduct.Size = new System.Drawing.Size(13, 13);
            this.numberofproduct.TabIndex = 25;
            this.numberofproduct.Text = "0";
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserName.Location = new System.Drawing.Point(889, 141);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(0, 20);
            this.lbUserName.TabIndex = 24;
            // 
            // lbHosgeldin
            // 
            this.lbHosgeldin.AutoSize = true;
            this.lbHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHosgeldin.Location = new System.Drawing.Point(889, 109);
            this.lbHosgeldin.Name = "lbHosgeldin";
            this.lbHosgeldin.Size = new System.Drawing.Size(0, 18);
            this.lbHosgeldin.TabIndex = 23;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBtn.Location = new System.Drawing.Point(2, 94);
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
            this.bookBtn.Location = new System.Drawing.Point(98, 94);
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
            this.magazineBtn.Location = new System.Drawing.Point(191, 94);
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
            this.musiccdBtn.Location = new System.Drawing.Point(287, 94);
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
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.billBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billBtn.BackgroundImage")));
            this.billBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.billBtn.Location = new System.Drawing.Point(383, 94);
            this.billBtn.Margin = new System.Windows.Forms.Padding(2);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(92, 123);
            this.billBtn.TabIndex = 21;
            this.billBtn.Text = "CART";
            this.billBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click_1);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.Location = new System.Drawing.Point(479, 94);
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
            // chancePasswordBtn
            // 
            this.chancePasswordBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chancePasswordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chancePasswordBtn.BackgroundImage")));
            this.chancePasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chancePasswordBtn.Location = new System.Drawing.Point(575, 96);
            this.chancePasswordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chancePasswordBtn.Name = "chancePasswordBtn";
            this.chancePasswordBtn.Size = new System.Drawing.Size(92, 123);
            this.chancePasswordBtn.TabIndex = 19;
            this.chancePasswordBtn.Text = "CHANGE PASSWORD";
            this.chancePasswordBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chancePasswordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chancePasswordBtn.UseVisualStyleBackColor = false;
            this.chancePasswordBtn.Visible = false;
            this.chancePasswordBtn.Click += new System.EventHandler(this.chancePasswordBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingBtn.BackgroundImage")));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingBtn.Location = new System.Drawing.Point(671, 94);
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
            // SearchReklamPanel
            // 
            this.SearchReklamPanel.Controls.Add(this.reklam1picturebox);
            this.SearchReklamPanel.Controls.Add(this.searchgroupBox);
            this.SearchReklamPanel.Controls.Add(this.reklam2picturebox);
            this.SearchReklamPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SearchReklamPanel.Location = new System.Drawing.Point(0, 219);
            this.SearchReklamPanel.Margin = new System.Windows.Forms.Padding(2);
            this.SearchReklamPanel.Name = "SearchReklamPanel";
            this.SearchReklamPanel.Size = new System.Drawing.Size(188, 465);
            this.SearchReklamPanel.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(824, 465);
            this.panel2.TabIndex = 0;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1012, 684);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SearchReklamPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).EndInit();
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchReklamPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox reklam1picturebox;
        private System.Windows.Forms.PictureBox reklam2picturebox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox searchgroupBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbPruduct;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label lbUserName;
        public System.Windows.Forms.Label lbHosgeldin;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button magazineBtn;
        private System.Windows.Forms.Button musiccdBtn;
        private System.Windows.Forms.Button billBtn;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button chancePasswordBtn;
        public System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Panel SearchReklamPanel;
        private System.Windows.Forms.FlowLayoutPanel panel2;
        public System.Windows.Forms.Label numberofproduct;
    }
}