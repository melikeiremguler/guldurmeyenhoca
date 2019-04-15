namespace oopProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbProductCount = new System.Windows.Forms.Label();
            this.lbFilter = new System.Windows.Forms.Label();
            this.lbPruduct = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBill);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(169, 554);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(0, 270);
            this.btnBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(169, 28);
            this.btnBill.TabIndex = 2;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 233);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(188, 25);
            this.cmbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(128, 24);
            this.cmbProduct.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbProductCount);
            this.groupBox2.Controls.Add(this.lbFilter);
            this.groupBox2.Controls.Add(this.lbPruduct);
            this.groupBox2.Controls.Add(this.cmbFiltre);
            this.groupBox2.Controls.Add(this.cmbProduct);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(169, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(898, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbProductCount
            // 
            this.lbProductCount.AutoSize = true;
            this.lbProductCount.Location = new System.Drawing.Point(811, 33);
            this.lbProductCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProductCount.Name = "lbProductCount";
            this.lbProductCount.Size = new System.Drawing.Size(16, 17);
            this.lbProductCount.TabIndex = 4;
            this.lbProductCount.Text = "0";
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Location = new System.Drawing.Point(377, 33);
            this.lbFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(39, 17);
            this.lbFilter.TabIndex = 3;
            this.lbFilter.Text = "Filter";
            // 
            // lbPruduct
            // 
            this.lbPruduct.AutoSize = true;
            this.lbPruduct.Location = new System.Drawing.Point(57, 33);
            this.lbPruduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPruduct.Name = "lbPruduct";
            this.lbPruduct.Size = new System.Drawing.Size(57, 17);
            this.lbPruduct.TabIndex = 2;
            this.lbPruduct.Text = "Product";
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Location = new System.Drawing.Point(453, 25);
            this.cmbFiltre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(128, 24);
            this.cmbFiltre.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Label lbPruduct;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label lbProductCount;
    }
}

