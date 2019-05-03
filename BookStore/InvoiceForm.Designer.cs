namespace BookStore
{
    partial class InvoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoiceForm));
            this.exit_lbl = new System.Windows.Forms.Label();
            this.logo_picturebox = new System.Windows.Forms.PictureBox();
            this.headerlbl = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.customernamelbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.customeraddresslbl = new System.Windows.Forms.Label();
            this.productlistview = new System.Windows.Forms.ListView();
            this.name_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amount_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit_price_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.login_button = new System.Windows.Forms.Button();
            this.totalpricelbl = new System.Windows.Forms.Label();
            this.customertotalpricelbl = new System.Windows.Forms.Label();
            this.installmentlbl = new System.Windows.Forms.Label();
            this.customerinstallmentlbl = new System.Windows.Forms.Label();
            this.total_price_column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_lbl
            // 
            this.exit_lbl.AutoSize = true;
            this.exit_lbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_lbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit_lbl.Location = new System.Drawing.Point(528, 3);
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
            this.logo_picturebox.Location = new System.Drawing.Point(166, 12);
            this.logo_picturebox.Name = "logo_picturebox";
            this.logo_picturebox.Size = new System.Drawing.Size(240, 70);
            this.logo_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_picturebox.TabIndex = 0;
            this.logo_picturebox.TabStop = false;
            this.logo_picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseDown);
            this.logo_picturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseMove);
            this.logo_picturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseUp);
            // 
            // headerlbl
            // 
            this.headerlbl.AutoSize = true;
            this.headerlbl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headerlbl.Location = new System.Drawing.Point(251, 85);
            this.headerlbl.Name = "headerlbl";
            this.headerlbl.Size = new System.Drawing.Size(75, 24);
            this.headerlbl.TabIndex = 9;
            this.headerlbl.Text = "Invoice";
            this.headerlbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseDown);
            this.headerlbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseMove);
            this.headerlbl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseUp);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.namelbl.Location = new System.Drawing.Point(24, 132);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(61, 16);
            this.namelbl.TabIndex = 10;
            this.namelbl.Text = "Name : ";
            // 
            // customernamelbl
            // 
            this.customernamelbl.AutoSize = true;
            this.customernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customernamelbl.Location = new System.Drawing.Point(118, 132);
            this.customernamelbl.Name = "customernamelbl";
            this.customernamelbl.Size = new System.Drawing.Size(13, 16);
            this.customernamelbl.TabIndex = 11;
            this.customernamelbl.Text = "-";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addresslbl.Location = new System.Drawing.Point(24, 159);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(74, 16);
            this.addresslbl.TabIndex = 14;
            this.addresslbl.Text = "Address :";
            // 
            // customeraddresslbl
            // 
            this.customeraddresslbl.AutoSize = true;
            this.customeraddresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customeraddresslbl.Location = new System.Drawing.Point(118, 159);
            this.customeraddresslbl.Name = "customeraddresslbl";
            this.customeraddresslbl.Size = new System.Drawing.Size(13, 16);
            this.customeraddresslbl.TabIndex = 15;
            this.customeraddresslbl.Text = "-";
            // 
            // productlistview
            // 
            this.productlistview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.productlistview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name_column,
            this.amount_column,
            this.unit_price_column,
            this.total_price_column});
            this.productlistview.Location = new System.Drawing.Point(27, 201);
            this.productlistview.Name = "productlistview";
            this.productlistview.Size = new System.Drawing.Size(500, 328);
            this.productlistview.TabIndex = 16;
            this.productlistview.UseCompatibleStateImageBehavior = false;
            this.productlistview.View = System.Windows.Forms.View.Details;
            this.productlistview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseDown);
            this.productlistview.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseMove);
            this.productlistview.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseUp);
            // 
            // name_column
            // 
            this.name_column.Text = "Name";
            this.name_column.Width = 200;
            // 
            // amount_column
            // 
            this.amount_column.Text = "Amount";
            this.amount_column.Width = 100;
            // 
            // unit_price_column
            // 
            this.unit_price_column.Text = "Unit Price";
            this.unit_price_column.Width = 100;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_button.ForeColor = System.Drawing.SystemColors.Control;
            this.login_button.Location = new System.Drawing.Point(420, 548);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(118, 31);
            this.login_button.TabIndex = 17;
            this.login_button.Text = "OK";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // totalpricelbl
            // 
            this.totalpricelbl.AutoSize = true;
            this.totalpricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalpricelbl.Location = new System.Drawing.Point(24, 540);
            this.totalpricelbl.Name = "totalpricelbl";
            this.totalpricelbl.Size = new System.Drawing.Size(92, 16);
            this.totalpricelbl.TabIndex = 18;
            this.totalpricelbl.Text = "Total Price :";
            // 
            // customertotalpricelbl
            // 
            this.customertotalpricelbl.AutoSize = true;
            this.customertotalpricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customertotalpricelbl.Location = new System.Drawing.Point(118, 540);
            this.customertotalpricelbl.Name = "customertotalpricelbl";
            this.customertotalpricelbl.Size = new System.Drawing.Size(13, 16);
            this.customertotalpricelbl.TabIndex = 19;
            this.customertotalpricelbl.Text = "-";
            // 
            // installmentlbl
            // 
            this.installmentlbl.AutoSize = true;
            this.installmentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.installmentlbl.Location = new System.Drawing.Point(24, 568);
            this.installmentlbl.Name = "installmentlbl";
            this.installmentlbl.Size = new System.Drawing.Size(90, 16);
            this.installmentlbl.TabIndex = 20;
            this.installmentlbl.Text = "Installment :";
            // 
            // customerinstallmentlbl
            // 
            this.customerinstallmentlbl.AutoSize = true;
            this.customerinstallmentlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerinstallmentlbl.Location = new System.Drawing.Point(118, 568);
            this.customerinstallmentlbl.Name = "customerinstallmentlbl";
            this.customerinstallmentlbl.Size = new System.Drawing.Size(13, 16);
            this.customerinstallmentlbl.TabIndex = 21;
            this.customerinstallmentlbl.Text = "-";
            // 
            // total_price_column
            // 
            this.total_price_column.Text = "Total Price";
            this.total_price_column.Width = 100;
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 593);
            this.Controls.Add(this.customerinstallmentlbl);
            this.Controls.Add(this.installmentlbl);
            this.Controls.Add(this.customertotalpricelbl);
            this.Controls.Add(this.totalpricelbl);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.productlistview);
            this.Controls.Add(this.customeraddresslbl);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.customernamelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.headerlbl);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.logo_picturebox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoiceForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InvoiceForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.logo_picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox logo_picturebox;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Label headerlbl;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label customernamelbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.Label customeraddresslbl;
        private System.Windows.Forms.ListView productlistview;
        private System.Windows.Forms.ColumnHeader name_column;
        private System.Windows.Forms.ColumnHeader amount_column;
        private System.Windows.Forms.ColumnHeader unit_price_column;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label totalpricelbl;
        private System.Windows.Forms.Label customertotalpricelbl;
        private System.Windows.Forms.Label installmentlbl;
        private System.Windows.Forms.Label customerinstallmentlbl;
        private System.Windows.Forms.ColumnHeader total_price_column;
    }
}