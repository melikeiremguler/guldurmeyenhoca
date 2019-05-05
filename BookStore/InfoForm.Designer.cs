namespace BookStore
{
    partial class InfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.picBoxImage = new System.Windows.Forms.PictureBox();
            this.lnName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxImage
            // 
            this.picBoxImage.BackColor = System.Drawing.Color.Transparent;
            this.picBoxImage.Location = new System.Drawing.Point(51, 50);
            this.picBoxImage.Name = "picBoxImage";
            this.picBoxImage.Size = new System.Drawing.Size(166, 127);
            this.picBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxImage.TabIndex = 0;
            this.picBoxImage.TabStop = false;
            // 
            // lnName
            // 
            this.lnName.AutoSize = true;
            this.lnName.BackColor = System.Drawing.Color.Transparent;
            this.lnName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnName.Location = new System.Drawing.Point(47, 201);
            this.lnName.Name = "lnName";
            this.lnName.Size = new System.Drawing.Size(59, 22);
            this.lnName.TabIndex = 1;
            this.lnName.Text = "label1";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Transparent;
            this.lbPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPrice.Location = new System.Drawing.Point(47, 315);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(59, 22);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "label1";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.BackColor = System.Drawing.Color.Transparent;
            this.lbPublisher.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPublisher.Location = new System.Drawing.Point(48, 254);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(40, 15);
            this.lbPublisher.TabIndex = 3;
            this.lbPublisher.Text = "label1";
            // 
            // lbDescription
            // 
            this.lbDescription.BackColor = System.Drawing.Color.Transparent;
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbDescription.Location = new System.Drawing.Point(277, 72);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(366, 265);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "label2";
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.BackColor = System.Drawing.Color.Transparent;
            this.lbPage.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPage.Location = new System.Drawing.Point(47, 363);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(40, 15);
            this.lbPage.TabIndex = 5;
            this.lbPage.Text = "label2";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPage);
            this.Controls.Add(this.lbDescription);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lnName);
            this.Controls.Add(this.picBoxImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picBoxImage;
        public System.Windows.Forms.Label lnName;
        public System.Windows.Forms.Label lbPrice;
        public System.Windows.Forms.Label lbPublisher;
        public System.Windows.Forms.Label lbDescription;
        public System.Windows.Forms.Label lbPage;
    }
}