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
<<<<<<< HEAD
            this.customerpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.magazineBtn = new System.Windows.Forms.Button();
            this.musiccdBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.creditcardBtn = new System.Windows.Forms.Button();
            this.chancePasswordBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
=======
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerpanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HomeBtn = new System.Windows.Forms.Button();
            this.bookBtn = new System.Windows.Forms.Button();
            this.magazineBtn = new System.Windows.Forms.Button();
            this.musiccdBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.creditcardBtn = new System.Windows.Forms.Button();
            this.chancePasswordBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.lbHosgeldin = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.searchgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.customerpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
<<<<<<< HEAD
            // customerpanel
            // 
            this.customerpanel.AutoSize = true;
            this.customerpanel.BackColor = System.Drawing.Color.Honeydew;
            this.customerpanel.Controls.Add(this.HomeBtn);
            this.customerpanel.Controls.Add(this.bookBtn);
            this.customerpanel.Controls.Add(this.magazineBtn);
            this.customerpanel.Controls.Add(this.musiccdBtn);
            this.customerpanel.Controls.Add(this.billBtn);
            this.customerpanel.Controls.Add(this.creditcardBtn);
            this.customerpanel.Controls.Add(this.chancePasswordBtn);
            this.customerpanel.Controls.Add(this.SettingBtn);
            this.customerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerpanel.Location = new System.Drawing.Point(0, 0);
            this.customerpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(1284, 847);
            this.customerpanel.TabIndex = 7;
            this.customerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.customerpanel_Paint);
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.HomeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeBtn.BackgroundImage")));
            this.HomeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeBtn.Location = new System.Drawing.Point(3, 2);
            this.HomeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(123, 151);
            this.HomeBtn.TabIndex = 5;
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
            this.bookBtn.Location = new System.Drawing.Point(132, 2);
            this.bookBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookBtn.Name = "bookBtn";
            this.bookBtn.Size = new System.Drawing.Size(123, 151);
            this.bookBtn.TabIndex = 6;
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
            this.magazineBtn.Location = new System.Drawing.Point(261, 2);
            this.magazineBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.magazineBtn.Name = "magazineBtn";
            this.magazineBtn.Size = new System.Drawing.Size(123, 151);
            this.magazineBtn.TabIndex = 7;
            this.magazineBtn.Text = "MAGAZINE";
            this.magazineBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.magazineBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.magazineBtn.UseVisualStyleBackColor = false;
            // 
            // musiccdBtn
            // 
            this.musiccdBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.musiccdBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("musiccdBtn.BackgroundImage")));
            this.musiccdBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musiccdBtn.Location = new System.Drawing.Point(390, 2);
            this.musiccdBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.musiccdBtn.Name = "musiccdBtn";
            this.musiccdBtn.Size = new System.Drawing.Size(123, 151);
            this.musiccdBtn.TabIndex = 8;
            this.musiccdBtn.Text = "MUSIC CD";
            this.musiccdBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musiccdBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.musiccdBtn.UseVisualStyleBackColor = false;
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.billBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billBtn.BackgroundImage")));
            this.billBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.billBtn.Location = new System.Drawing.Point(519, 2);
            this.billBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(123, 151);
            this.billBtn.TabIndex = 12;
            this.billBtn.Text = "SHOPPING CART";
            this.billBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.billBtn.UseVisualStyleBackColor = false;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // creditcardBtn
            // 
            this.creditcardBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.creditcardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("creditcardBtn.BackgroundImage")));
            this.creditcardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.creditcardBtn.Location = new System.Drawing.Point(648, 2);
            this.creditcardBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creditcardBtn.Name = "creditcardBtn";
            this.creditcardBtn.Size = new System.Drawing.Size(123, 151);
            this.creditcardBtn.TabIndex = 11;
            this.creditcardBtn.Text = "CREDIT CARD";
            this.creditcardBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.creditcardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.creditcardBtn.UseVisualStyleBackColor = false;
            // 
            // chancePasswordBtn
            // 
            this.chancePasswordBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.chancePasswordBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chancePasswordBtn.BackgroundImage")));
            this.chancePasswordBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chancePasswordBtn.Location = new System.Drawing.Point(777, 2);
            this.chancePasswordBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chancePasswordBtn.Name = "chancePasswordBtn";
            this.chancePasswordBtn.Size = new System.Drawing.Size(123, 151);
            this.chancePasswordBtn.TabIndex = 10;
            this.chancePasswordBtn.Text = "CHANGE PASSWORD";
            this.chancePasswordBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chancePasswordBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chancePasswordBtn.UseVisualStyleBackColor = false;
            this.chancePasswordBtn.Click += new System.EventHandler(this.chancePasswordBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.SettingBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingBtn.BackgroundImage")));
            this.SettingBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingBtn.Location = new System.Drawing.Point(906, 2);
            this.SettingBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(123, 151);
            this.SettingBtn.TabIndex = 9;
            this.SettingBtn.Text = "SETTINGS";
            this.SettingBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SettingBtn.UseVisualStyleBackColor = false;
            // 
=======
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.BackColor = System.Drawing.Color.SeaShell;
<<<<<<< HEAD
            this.lbFilter.Location = new System.Drawing.Point(13, 106);
            this.lbFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lbFilter.Location = new System.Drawing.Point(10, 77);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(39, 17);
            this.lbFilter.TabIndex = 11;
            this.lbFilter.Text = "Filter";
            // 
            // lbPruduct
            // 
            this.lbPruduct.AutoSize = true;
            this.lbPruduct.BackColor = System.Drawing.Color.SeaShell;
<<<<<<< HEAD
            this.lbPruduct.Location = new System.Drawing.Point(13, 66);
            this.lbPruduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
=======
            this.lbPruduct.Location = new System.Drawing.Point(10, 50);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.lbPruduct.Name = "lbPruduct";
            this.lbPruduct.Size = new System.Drawing.Size(57, 17);
            this.lbPruduct.TabIndex = 10;
            this.lbPruduct.Text = "Product";
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
<<<<<<< HEAD
            this.cmbFiltre.Location = new System.Drawing.Point(100, 100);
            this.cmbFiltre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.cmbFiltre.Location = new System.Drawing.Point(75, 69);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(144, 24);
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
<<<<<<< HEAD
            this.cmbProduct.Location = new System.Drawing.Point(100, 63);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
=======
            this.cmbProduct.Location = new System.Drawing.Point(75, 42);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(144, 24);
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
<<<<<<< HEAD
            this.searchgroupBox.Location = new System.Drawing.Point(3, 166);
            this.searchgroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchgroupBox.Name = "searchgroupBox";
            this.searchgroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchgroupBox.Size = new System.Drawing.Size(252, 166);
=======
            this.searchgroupBox.Location = new System.Drawing.Point(2, 152);
            this.searchgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchgroupBox.Name = "searchgroupBox";
            this.searchgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.searchgroupBox.Size = new System.Drawing.Size(189, 123);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.searchgroupBox.TabIndex = 12;
            this.searchgroupBox.TabStop = false;
            // 
            // searchBtn
            // 
<<<<<<< HEAD
            this.searchBtn.Location = new System.Drawing.Point(141, 137);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.searchBtn.Location = new System.Drawing.Point(99, 95);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
<<<<<<< HEAD
            this.textBox1.Location = new System.Drawing.Point(17, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
=======
            this.textBox1.Location = new System.Drawing.Point(9, 17);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 15;
            // 
            // reklam1picturebox
            // 
            this.reklam1picturebox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reklam1picturebox.Location = new System.Drawing.Point(0, 338);
            this.reklam1picturebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reklam1picturebox.Name = "reklam1picturebox";
            this.reklam1picturebox.Size = new System.Drawing.Size(255, 230);
            this.reklam1picturebox.TabIndex = 13;
            this.reklam1picturebox.TabStop = false;
            // 
            // reklam2picturebox
            // 
            this.reklam2picturebox.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.reklam2picturebox.Location = new System.Drawing.Point(-1, 574);
            this.reklam2picturebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reklam2picturebox.Name = "reklam2picturebox";
            this.reklam2picturebox.Size = new System.Drawing.Size(255, 230);
            this.reklam2picturebox.TabIndex = 14;
            this.reklam2picturebox.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox6, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox7, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox8, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox9, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox10, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(301, 229);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 436);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(648, 387);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 49);
            this.label10.TabIndex = 21;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(487, 387);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 49);
            this.label9.TabIndex = 20;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(326, 387);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 49);
            this.label8.TabIndex = 19;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(165, 387);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 49);
            this.label7.TabIndex = 18;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(4, 387);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 49);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(648, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 43);
            this.label5.TabIndex = 16;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(487, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 43);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(326, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 43);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 164);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(165, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 164);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(326, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(153, 164);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox6.Location = new System.Drawing.Point(487, 4);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(153, 164);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(648, 4);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(157, 164);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox5.Location = new System.Drawing.Point(4, 219);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(153, 164);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox7.Location = new System.Drawing.Point(165, 219);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(153, 164);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox8.Location = new System.Drawing.Point(326, 219);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(153, 164);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox9.Location = new System.Drawing.Point(487, 219);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(153, 164);
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox10.Location = new System.Drawing.Point(648, 219);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(157, 164);
            this.pictureBox10.TabIndex = 11;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 43);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(165, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 43);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // customerpanel
            // 
            this.customerpanel.AutoSize = true;
            this.customerpanel.BackColor = System.Drawing.Color.Honeydew;
            this.customerpanel.Controls.Add(this.panel1);
            this.customerpanel.Controls.Add(this.searchgroupBox);
            this.customerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerpanel.Location = new System.Drawing.Point(0, 0);
            this.customerpanel.Margin = new System.Windows.Forms.Padding(2);
            this.customerpanel.Name = "customerpanel";
            this.customerpanel.Size = new System.Drawing.Size(1022, 688);
            this.customerpanel.TabIndex = 7;
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
            this.panel1.Controls.Add(this.billBtn);
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
            // 
            // billBtn
            // 
            this.billBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.billBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("billBtn.BackgroundImage")));
            this.billBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.billBtn.Location = new System.Drawing.Point(383, 8);
            this.billBtn.Margin = new System.Windows.Forms.Padding(2);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(92, 123);
            this.billBtn.TabIndex = 21;
            this.billBtn.Text = "CART";
            this.billBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.billBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.billBtn.UseVisualStyleBackColor = false;
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
            // lbHosgeldin
            // 
            this.lbHosgeldin.AutoSize = true;
            this.lbHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbHosgeldin.Location = new System.Drawing.Point(889, 51);
            this.lbHosgeldin.Name = "lbHosgeldin";
            this.lbHosgeldin.Size = new System.Drawing.Size(0, 18);
            this.lbHosgeldin.TabIndex = 23;
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
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1284, 847);
=======
            this.ClientSize = new System.Drawing.Size(1022, 688);
>>>>>>> 5db6209ebe1597b81ec6a7f757b0f045b2272432
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reklam2picturebox);
            this.Controls.Add(this.reklam1picturebox);
            this.Controls.Add(this.customerpanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomerForm";
            this.Text = "BookStore";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.searchgroupBox.ResumeLayout(false);
            this.searchgroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reklam1picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reklam2picturebox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel customerpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button bookBtn;
        private System.Windows.Forms.Button magazineBtn;
        private System.Windows.Forms.Button musiccdBtn;
        private System.Windows.Forms.Button billBtn;
        public System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.Button creditcardBtn;
        public System.Windows.Forms.Button chancePasswordBtn;
        public System.Windows.Forms.Button SettingBtn;
        public System.Windows.Forms.Label lbHosgeldin;
        public System.Windows.Forms.Label lbUserName;
    }
}