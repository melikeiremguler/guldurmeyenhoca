namespace BookStore
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.panelyaziLbl = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.StokBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.chancePasswordBtn = new System.Windows.Forms.Button();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.magazineBtn = new System.Windows.Forms.Button();
            this.musiccdBtn = new System.Windows.Forms.Button();
            this.reklam2picturebox = new System.Windows.Forms.PictureBox();
            this.reklam1picturebox = new System.Windows.Forms.PictureBox();
            this.searchgroupBox = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.Searchtxt = new System.Windows.Forms.TextBox();
            this.lbFilter = new System.Windows.Forms.Label();
            this.lbPruduct = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdminprintPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.AdminPanel.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).BeginInit();
            this.searchgroupBox.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminPanel
            // 
            this.AdminPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.AdminPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminPanel.BackgroundImage")));
            this.AdminPanel.Controls.Add(this.panelyaziLbl);
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AdminPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(988, 80);
            this.AdminPanel.TabIndex = 0;
            // 
            // panelyaziLbl
            // 
            this.panelyaziLbl.AutoSize = true;
            this.panelyaziLbl.BackColor = System.Drawing.Color.Transparent;
            this.panelyaziLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelyaziLbl.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.panelyaziLbl.Location = new System.Drawing.Point(38, 7);
            this.panelyaziLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.panelyaziLbl.Name = "panelyaziLbl";
            this.panelyaziLbl.Size = new System.Drawing.Size(719, 44);
            this.panelyaziLbl.TabIndex = 0;
            this.panelyaziLbl.Text = "BOOK SHOP MANAGEMENT SYSTEM";
            this.panelyaziLbl.Click += new System.EventHandler(this.panelyaziLbl_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.StokBtn);
            this.panelMenu.Controls.Add(this.AddBtn);
            this.panelMenu.Controls.Add(this.customerBtn);
            this.panelMenu.Controls.Add(this.SettingBtn);
            this.panelMenu.Controls.Add(this.chancePasswordBtn);
            this.panelMenu.Controls.Add(this.HomeBtn);
            this.panelMenu.Controls.Add(this.bookBtn);
            this.panelMenu.Controls.Add(this.magazineBtn);
            this.panelMenu.Controls.Add(this.musiccdBtn);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 80);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(988, 119);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StokBtn
            // 
            this.StokBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.StokBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StokBtn.BackgroundImage")));
            this.StokBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StokBtn.Location = new System.Drawing.Point(585, -16);
            this.StokBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StokBtn.Name = "StokBtn";
            this.StokBtn.Size = new System.Drawing.Size(94, 123);
            this.StokBtn.TabIndex = 21;
            this.StokBtn.Text = "STOCK";
            this.StokBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StokBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.StokBtn.UseVisualStyleBackColor = false;
            this.StokBtn.Click += new System.EventHandler(this.StokBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBtn.Location = new System.Drawing.Point(489, -16);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 123);
            this.AddBtn.TabIndex = 20;
            this.AddBtn.Text = "ADD PRODUCT";
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.AddBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.customerBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("customerBtn.BackgroundImage")));
            this.customerBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customerBtn.Location = new System.Drawing.Point(393, -16);
            this.customerBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(94, 123);
            this.customerBtn.TabIndex = 19;
            this.customerBtn.Text = "CUSTOMERS";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingBtn.BackgroundImage")));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingBtn.Location = new System.Drawing.Point(681, -16);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(94, 123);
            this.SettingBtn.TabIndex = 17;
            this.SettingBtn.Text = "SETTINGS";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SettingBtn.UseVisualStyleBackColor = false;
            // 
            // chancePasswordBtn
            // 
            this.chancePasswordBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chancePasswordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chancePasswordBtn.BackgroundImage")));
            this.chancePasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chancePasswordBtn.Location = new System.Drawing.Point(777, -16);
            this.chancePasswordBtn.Margin = new System.Windows.Forms.Padding(2);
            this.chancePasswordBtn.Name = "chancePasswordBtn";
            this.chancePasswordBtn.Size = new System.Drawing.Size(94, 123);
            this.chancePasswordBtn.TabIndex = 18;
            this.chancePasswordBtn.Text = "CHANGE PASSWORD";
            this.chancePasswordBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chancePasswordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chancePasswordBtn.UseVisualStyleBackColor = false;
            this.chancePasswordBtn.Click += new System.EventHandler(this.chancePasswordBtn_Click);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBtn.Location = new System.Drawing.Point(9, -13);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(94, 123);
            this.HomeBtn.TabIndex = 13;
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
            this.bookBtn.Location = new System.Drawing.Point(105, -13);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(94, 123);
            this.bookBtn.TabIndex = 14;
            this.bookBtn.Text = "BOOK";
            this.bookBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bookBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.bookBtn.UseVisualStyleBackColor = false;
            this.bookBtn.Click += new System.EventHandler(this.bookBtn_Click);
            // 
            // magazineBtn
            // 
            this.magazineBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.magazineBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("magazineBtn.BackgroundImage")));
            this.magazineBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.magazineBtn.Location = new System.Drawing.Point(201, -16);
            this.magazineBtn.Margin = new System.Windows.Forms.Padding(2);
            this.magazineBtn.Name = "magazineBtn";
            this.magazineBtn.Size = new System.Drawing.Size(94, 123);
            this.magazineBtn.TabIndex = 15;
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
            this.musiccdBtn.Location = new System.Drawing.Point(297, -13);
            this.musiccdBtn.Margin = new System.Windows.Forms.Padding(2);
            this.musiccdBtn.Name = "musiccdBtn";
            this.musiccdBtn.Size = new System.Drawing.Size(94, 120);
            this.musiccdBtn.TabIndex = 16;
            this.musiccdBtn.Text = "MUSIC CD";
            this.musiccdBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musiccdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.musiccdBtn.UseVisualStyleBackColor = false;
            this.musiccdBtn.Click += new System.EventHandler(this.musiccdBtn_Click);
            // 
            // reklam2picturebox
            // 
            this.reklam2picturebox.Location = new System.Drawing.Point(2, 332);
            this.reklam2picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.reklam2picturebox.Name = "reklam2picturebox";
            this.reklam2picturebox.Size = new System.Drawing.Size(191, 187);
            this.reklam2picturebox.TabIndex = 17;
            this.reklam2picturebox.TabStop = false;
            this.reklam2picturebox.Click += new System.EventHandler(this.reklam2picturebox_Click);
            // 
            // reklam1picturebox
            // 
            this.reklam1picturebox.Location = new System.Drawing.Point(0, 141);
            this.reklam1picturebox.Margin = new System.Windows.Forms.Padding(2);
            this.reklam1picturebox.Name = "reklam1picturebox";
            this.reklam1picturebox.Size = new System.Drawing.Size(191, 187);
            this.reklam1picturebox.TabIndex = 16;
            this.reklam1picturebox.TabStop = false;
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
            this.searchgroupBox.Location = new System.Drawing.Point(2, 2);
            this.searchgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchgroupBox.Name = "searchgroupBox";
            this.searchgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchgroupBox.Size = new System.Drawing.Size(189, 135);
            this.searchgroupBox.TabIndex = 15;
            this.searchgroupBox.TabStop = false;
            this.searchgroupBox.Enter += new System.EventHandler(this.searchgroupBox_Enter);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(106, 111);
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
            this.Searchtxt.Location = new System.Drawing.Point(8, 28);
            this.Searchtxt.Margin = new System.Windows.Forms.Padding(2);
            this.Searchtxt.Name = "Searchtxt";
            this.Searchtxt.Size = new System.Drawing.Size(156, 20);
            this.Searchtxt.TabIndex = 15;
            this.Searchtxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.BackColor = System.Drawing.Color.SeaShell;
            this.lbFilter.Location = new System.Drawing.Point(8, 84);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(29, 13);
            this.lbFilter.TabIndex = 11;
            this.lbFilter.Text = "Filter";
            // 
            // lbPruduct
            // 
            this.lbPruduct.AutoSize = true;
            this.lbPruduct.BackColor = System.Drawing.Color.SeaShell;
            this.lbPruduct.Location = new System.Drawing.Point(8, 57);
            this.lbPruduct.Name = "lbPruduct";
            this.lbPruduct.Size = new System.Drawing.Size(44, 13);
            this.lbPruduct.TabIndex = 10;
            this.lbPruduct.Text = "Product";
            this.lbPruduct.Click += new System.EventHandler(this.lbPruduct_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(54, 82);
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
            this.cmbProduct.Location = new System.Drawing.Point(54, 51);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(109, 21);
            this.cmbProduct.TabIndex = 8;
            this.cmbProduct.Text = "Select";
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminprintPanel
            // 
            this.AdminprintPanel.AutoScroll = true;
            this.AdminprintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminprintPanel.Location = new System.Drawing.Point(195, 199);
            this.AdminprintPanel.Name = "AdminprintPanel";
            this.AdminprintPanel.Size = new System.Drawing.Size(793, 550);
            this.AdminprintPanel.TabIndex = 19;
            // 
            // panelSearch
            // 
            this.panelSearch.AutoSize = true;
            this.panelSearch.Controls.Add(this.searchgroupBox);
            this.panelSearch.Controls.Add(this.reklam1picturebox);
            this.panelSearch.Controls.Add(this.reklam2picturebox);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearch.Location = new System.Drawing.Point(0, 199);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(195, 550);
            this.panelSearch.TabIndex = 20;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(988, 749);
            this.Controls.Add(this.AdminprintPanel);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.AdminPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.AdminPanel.ResumeLayout(false);
            this.AdminPanel.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).EndInit();
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Label panelyaziLbl;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button magazineBtn;
        private System.Windows.Forms.Button musiccdBtn;
        private System.Windows.Forms.PictureBox reklam2picturebox;
        private System.Windows.Forms.PictureBox reklam1picturebox;
        private System.Windows.Forms.GroupBox searchgroupBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox Searchtxt;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbPruduct;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button StokBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button chancePasswordBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel AdminprintPanel;
        private System.Windows.Forms.Panel panelSearch;
    }
}