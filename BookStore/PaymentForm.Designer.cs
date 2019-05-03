namespace BookStore
{
    partial class PaymentForm
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
            this.cash_radiobutton = new System.Windows.Forms.RadioButton();
            this.creditcard_radiobutton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.creditcart_groupbox = new System.Windows.Forms.GroupBox();
            this.cvv_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.expirydate_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardnumber_maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.installment_groupbox = new System.Windows.Forms.GroupBox();
            this.sixth_total_lbl = new System.Windows.Forms.Label();
            this.installment_option_lbl = new System.Windows.Forms.Label();
            this.twelve_total_lbl = new System.Windows.Forms.Label();
            this.first_installment_radiobutton = new System.Windows.Forms.RadioButton();
            this.third_total_lbl = new System.Windows.Forms.Label();
            this.number_installment_lbl = new System.Windows.Forms.Label();
            this.first_total_lbl = new System.Windows.Forms.Label();
            this.monthly_payment_lbl = new System.Windows.Forms.Label();
            this.twelve_payment_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.sixth_payment_lbl = new System.Windows.Forms.Label();
            this.third_installment_radiobutton = new System.Windows.Forms.RadioButton();
            this.third_payment_lbl = new System.Windows.Forms.Label();
            this.sixth_installment_radiobutton = new System.Windows.Forms.RadioButton();
            this.first_payment_lbl = new System.Windows.Forms.Label();
            this.twelve_installment_radiobutton = new System.Windows.Forms.RadioButton();
            this.name_txtbox = new System.Windows.Forms.TextBox();
            this.cvv_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.card_number_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.buy_button = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.customeraddresstxtbox = new System.Windows.Forms.TextBox();
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.creditcart_groupbox.SuspendLayout();
            this.installment_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cash_radiobutton
            // 
            this.cash_radiobutton.AutoSize = true;
            this.cash_radiobutton.Location = new System.Drawing.Point(6, 19);
            this.cash_radiobutton.Name = "cash_radiobutton";
            this.cash_radiobutton.Size = new System.Drawing.Size(49, 17);
            this.cash_radiobutton.TabIndex = 1;
            this.cash_radiobutton.TabStop = true;
            this.cash_radiobutton.Text = "Cash";
            this.cash_radiobutton.UseVisualStyleBackColor = true;
            this.cash_radiobutton.CheckedChanged += new System.EventHandler(this.cash_radiobutton_CheckedChanged);
            // 
            // creditcard_radiobutton
            // 
            this.creditcard_radiobutton.AutoSize = true;
            this.creditcard_radiobutton.Location = new System.Drawing.Point(141, 19);
            this.creditcard_radiobutton.Name = "creditcard_radiobutton";
            this.creditcard_radiobutton.Size = new System.Drawing.Size(74, 17);
            this.creditcard_radiobutton.TabIndex = 2;
            this.creditcard_radiobutton.TabStop = true;
            this.creditcard_radiobutton.Text = "CreditCard";
            this.creditcard_radiobutton.UseVisualStyleBackColor = true;
            this.creditcard_radiobutton.CheckedChanged += new System.EventHandler(this.creditcard_radiobutton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.creditcard_radiobutton);
            this.groupBox1.Controls.Add(this.cash_radiobutton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Type";
            // 
            // creditcart_groupbox
            // 
            this.creditcart_groupbox.Controls.Add(this.cvv_maskedTextBox);
            this.creditcart_groupbox.Controls.Add(this.expirydate_maskedTextBox);
            this.creditcart_groupbox.Controls.Add(this.cardnumber_maskedTextBox);
            this.creditcart_groupbox.Controls.Add(this.installment_groupbox);
            this.creditcart_groupbox.Controls.Add(this.name_txtbox);
            this.creditcart_groupbox.Controls.Add(this.cvv_lbl);
            this.creditcart_groupbox.Controls.Add(this.label1);
            this.creditcart_groupbox.Controls.Add(this.card_number_lbl);
            this.creditcart_groupbox.Controls.Add(this.name_lbl);
            this.creditcart_groupbox.Location = new System.Drawing.Point(13, 154);
            this.creditcart_groupbox.Name = "creditcart_groupbox";
            this.creditcart_groupbox.Size = new System.Drawing.Size(399, 310);
            this.creditcart_groupbox.TabIndex = 9;
            this.creditcart_groupbox.TabStop = false;
            this.creditcart_groupbox.Text = "Credit Cart";
            // 
            // cvv_maskedTextBox
            // 
            this.cvv_maskedTextBox.Location = new System.Drawing.Point(256, 112);
            this.cvv_maskedTextBox.Mask = "000";
            this.cvv_maskedTextBox.Name = "cvv_maskedTextBox";
            this.cvv_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cvv_maskedTextBox.TabIndex = 17;
            // 
            // expirydate_maskedTextBox
            // 
            this.expirydate_maskedTextBox.Location = new System.Drawing.Point(256, 58);
            this.expirydate_maskedTextBox.Mask = "00-0000";
            this.expirydate_maskedTextBox.Name = "expirydate_maskedTextBox";
            this.expirydate_maskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.expirydate_maskedTextBox.TabIndex = 13;
            // 
            // cardnumber_maskedTextBox
            // 
            this.cardnumber_maskedTextBox.Location = new System.Drawing.Point(9, 112);
            this.cardnumber_maskedTextBox.Mask = "0000-0000-0000-0000";
            this.cardnumber_maskedTextBox.Name = "cardnumber_maskedTextBox";
            this.cardnumber_maskedTextBox.Size = new System.Drawing.Size(148, 20);
            this.cardnumber_maskedTextBox.TabIndex = 15;
            // 
            // installment_groupbox
            // 
            this.installment_groupbox.Controls.Add(this.sixth_total_lbl);
            this.installment_groupbox.Controls.Add(this.installment_option_lbl);
            this.installment_groupbox.Controls.Add(this.twelve_total_lbl);
            this.installment_groupbox.Controls.Add(this.first_installment_radiobutton);
            this.installment_groupbox.Controls.Add(this.third_total_lbl);
            this.installment_groupbox.Controls.Add(this.number_installment_lbl);
            this.installment_groupbox.Controls.Add(this.first_total_lbl);
            this.installment_groupbox.Controls.Add(this.monthly_payment_lbl);
            this.installment_groupbox.Controls.Add(this.twelve_payment_lbl);
            this.installment_groupbox.Controls.Add(this.total_lbl);
            this.installment_groupbox.Controls.Add(this.sixth_payment_lbl);
            this.installment_groupbox.Controls.Add(this.third_installment_radiobutton);
            this.installment_groupbox.Controls.Add(this.third_payment_lbl);
            this.installment_groupbox.Controls.Add(this.sixth_installment_radiobutton);
            this.installment_groupbox.Controls.Add(this.first_payment_lbl);
            this.installment_groupbox.Controls.Add(this.twelve_installment_radiobutton);
            this.installment_groupbox.Location = new System.Drawing.Point(6, 150);
            this.installment_groupbox.Name = "installment_groupbox";
            this.installment_groupbox.Size = new System.Drawing.Size(384, 152);
            this.installment_groupbox.TabIndex = 18;
            this.installment_groupbox.TabStop = false;
            this.installment_groupbox.Text = "Installment";
            // 
            // sixth_total_lbl
            // 
            this.sixth_total_lbl.AutoSize = true;
            this.sixth_total_lbl.Location = new System.Drawing.Point(253, 100);
            this.sixth_total_lbl.MaximumSize = new System.Drawing.Size(100, 0);
            this.sixth_total_lbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.sixth_total_lbl.Name = "sixth_total_lbl";
            this.sixth_total_lbl.Size = new System.Drawing.Size(100, 13);
            this.sixth_total_lbl.TabIndex = 33;
            this.sixth_total_lbl.Text = "-";
            this.sixth_total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // installment_option_lbl
            // 
            this.installment_option_lbl.AutoSize = true;
            this.installment_option_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.installment_option_lbl.Location = new System.Drawing.Point(6, 16);
            this.installment_option_lbl.Name = "installment_option_lbl";
            this.installment_option_lbl.Size = new System.Drawing.Size(131, 16);
            this.installment_option_lbl.TabIndex = 19;
            this.installment_option_lbl.Text = "Installment Option";
            // 
            // twelve_total_lbl
            // 
            this.twelve_total_lbl.AutoSize = true;
            this.twelve_total_lbl.Location = new System.Drawing.Point(253, 123);
            this.twelve_total_lbl.MaximumSize = new System.Drawing.Size(100, 0);
            this.twelve_total_lbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.twelve_total_lbl.Name = "twelve_total_lbl";
            this.twelve_total_lbl.Size = new System.Drawing.Size(100, 13);
            this.twelve_total_lbl.TabIndex = 34;
            this.twelve_total_lbl.Text = "-";
            this.twelve_total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // first_installment_radiobutton
            // 
            this.first_installment_radiobutton.AutoSize = true;
            this.first_installment_radiobutton.Checked = true;
            this.first_installment_radiobutton.Location = new System.Drawing.Point(9, 54);
            this.first_installment_radiobutton.Name = "first_installment_radiobutton";
            this.first_installment_radiobutton.Size = new System.Drawing.Size(97, 17);
            this.first_installment_radiobutton.TabIndex = 21;
            this.first_installment_radiobutton.TabStop = true;
            this.first_installment_radiobutton.Text = "First Installment";
            this.first_installment_radiobutton.UseVisualStyleBackColor = true;
            // 
            // third_total_lbl
            // 
            this.third_total_lbl.AutoSize = true;
            this.third_total_lbl.Location = new System.Drawing.Point(253, 78);
            this.third_total_lbl.MaximumSize = new System.Drawing.Size(100, 0);
            this.third_total_lbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.third_total_lbl.Name = "third_total_lbl";
            this.third_total_lbl.Size = new System.Drawing.Size(100, 13);
            this.third_total_lbl.TabIndex = 32;
            this.third_total_lbl.Text = "-";
            this.third_total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // number_installment_lbl
            // 
            this.number_installment_lbl.AutoSize = true;
            this.number_installment_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.number_installment_lbl.Location = new System.Drawing.Point(6, 35);
            this.number_installment_lbl.Name = "number_installment_lbl";
            this.number_installment_lbl.Size = new System.Drawing.Size(111, 13);
            this.number_installment_lbl.TabIndex = 20;
            this.number_installment_lbl.Text = "Number Of Installment";
            // 
            // first_total_lbl
            // 
            this.first_total_lbl.AutoSize = true;
            this.first_total_lbl.Location = new System.Drawing.Point(252, 54);
            this.first_total_lbl.MaximumSize = new System.Drawing.Size(100, 0);
            this.first_total_lbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.first_total_lbl.Name = "first_total_lbl";
            this.first_total_lbl.Size = new System.Drawing.Size(100, 13);
            this.first_total_lbl.TabIndex = 31;
            this.first_total_lbl.Text = "-";
            this.first_total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthly_payment_lbl
            // 
            this.monthly_payment_lbl.AutoSize = true;
            this.monthly_payment_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.monthly_payment_lbl.Location = new System.Drawing.Point(140, 35);
            this.monthly_payment_lbl.Name = "monthly_payment_lbl";
            this.monthly_payment_lbl.Size = new System.Drawing.Size(88, 13);
            this.monthly_payment_lbl.TabIndex = 25;
            this.monthly_payment_lbl.Text = "Monthly Payment";
            // 
            // twelve_payment_lbl
            // 
            this.twelve_payment_lbl.AutoSize = true;
            this.twelve_payment_lbl.Location = new System.Drawing.Point(147, 125);
            this.twelve_payment_lbl.MaximumSize = new System.Drawing.Size(72, 0);
            this.twelve_payment_lbl.MinimumSize = new System.Drawing.Size(72, 0);
            this.twelve_payment_lbl.Name = "twelve_payment_lbl";
            this.twelve_payment_lbl.Size = new System.Drawing.Size(72, 13);
            this.twelve_payment_lbl.TabIndex = 29;
            this.twelve_payment_lbl.Text = "-";
            this.twelve_payment_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // total_lbl
            // 
            this.total_lbl.AutoSize = true;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_lbl.Location = new System.Drawing.Point(253, 35);
            this.total_lbl.MaximumSize = new System.Drawing.Size(100, 0);
            this.total_lbl.MinimumSize = new System.Drawing.Size(100, 0);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(100, 13);
            this.total_lbl.TabIndex = 30;
            this.total_lbl.Text = "Total";
            this.total_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixth_payment_lbl
            // 
            this.sixth_payment_lbl.AutoSize = true;
            this.sixth_payment_lbl.Location = new System.Drawing.Point(147, 100);
            this.sixth_payment_lbl.MaximumSize = new System.Drawing.Size(72, 0);
            this.sixth_payment_lbl.MinimumSize = new System.Drawing.Size(72, 0);
            this.sixth_payment_lbl.Name = "sixth_payment_lbl";
            this.sixth_payment_lbl.Size = new System.Drawing.Size(72, 13);
            this.sixth_payment_lbl.TabIndex = 28;
            this.sixth_payment_lbl.Text = "-";
            this.sixth_payment_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // third_installment_radiobutton
            // 
            this.third_installment_radiobutton.AutoSize = true;
            this.third_installment_radiobutton.Location = new System.Drawing.Point(9, 77);
            this.third_installment_radiobutton.Name = "third_installment_radiobutton";
            this.third_installment_radiobutton.Size = new System.Drawing.Size(102, 17);
            this.third_installment_radiobutton.TabIndex = 22;
            this.third_installment_radiobutton.TabStop = true;
            this.third_installment_radiobutton.Text = "Third Installment";
            this.third_installment_radiobutton.UseVisualStyleBackColor = true;
            // 
            // third_payment_lbl
            // 
            this.third_payment_lbl.AutoSize = true;
            this.third_payment_lbl.Location = new System.Drawing.Point(147, 77);
            this.third_payment_lbl.MaximumSize = new System.Drawing.Size(72, 0);
            this.third_payment_lbl.MinimumSize = new System.Drawing.Size(72, 0);
            this.third_payment_lbl.Name = "third_payment_lbl";
            this.third_payment_lbl.Size = new System.Drawing.Size(72, 13);
            this.third_payment_lbl.TabIndex = 27;
            this.third_payment_lbl.Text = "-";
            this.third_payment_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sixth_installment_radiobutton
            // 
            this.sixth_installment_radiobutton.AutoSize = true;
            this.sixth_installment_radiobutton.Location = new System.Drawing.Point(9, 100);
            this.sixth_installment_radiobutton.Name = "sixth_installment_radiobutton";
            this.sixth_installment_radiobutton.Size = new System.Drawing.Size(101, 17);
            this.sixth_installment_radiobutton.TabIndex = 23;
            this.sixth_installment_radiobutton.TabStop = true;
            this.sixth_installment_radiobutton.Text = "Sixth Installment";
            this.sixth_installment_radiobutton.UseVisualStyleBackColor = true;
            // 
            // first_payment_lbl
            // 
            this.first_payment_lbl.AutoSize = true;
            this.first_payment_lbl.Location = new System.Drawing.Point(147, 54);
            this.first_payment_lbl.MaximumSize = new System.Drawing.Size(72, 0);
            this.first_payment_lbl.MinimumSize = new System.Drawing.Size(72, 0);
            this.first_payment_lbl.Name = "first_payment_lbl";
            this.first_payment_lbl.Size = new System.Drawing.Size(72, 13);
            this.first_payment_lbl.TabIndex = 26;
            this.first_payment_lbl.Text = "-";
            this.first_payment_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twelve_installment_radiobutton
            // 
            this.twelve_installment_radiobutton.AutoSize = true;
            this.twelve_installment_radiobutton.Location = new System.Drawing.Point(9, 123);
            this.twelve_installment_radiobutton.Name = "twelve_installment_radiobutton";
            this.twelve_installment_radiobutton.Size = new System.Drawing.Size(113, 17);
            this.twelve_installment_radiobutton.TabIndex = 24;
            this.twelve_installment_radiobutton.TabStop = true;
            this.twelve_installment_radiobutton.Text = "Twelve Installment";
            this.twelve_installment_radiobutton.UseVisualStyleBackColor = true;
            // 
            // name_txtbox
            // 
            this.name_txtbox.Location = new System.Drawing.Point(9, 58);
            this.name_txtbox.Name = "name_txtbox";
            this.name_txtbox.Size = new System.Drawing.Size(148, 20);
            this.name_txtbox.TabIndex = 11;
            // 
            // cvv_lbl
            // 
            this.cvv_lbl.AutoSize = true;
            this.cvv_lbl.Location = new System.Drawing.Point(260, 94);
            this.cvv_lbl.Name = "cvv_lbl";
            this.cvv_lbl.Size = new System.Drawing.Size(28, 13);
            this.cvv_lbl.TabIndex = 16;
            this.cvv_lbl.Text = "CVV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Expiry Date";
            // 
            // card_number_lbl
            // 
            this.card_number_lbl.AutoSize = true;
            this.card_number_lbl.Location = new System.Drawing.Point(6, 94);
            this.card_number_lbl.Name = "card_number_lbl";
            this.card_number_lbl.Size = new System.Drawing.Size(67, 13);
            this.card_number_lbl.TabIndex = 14;
            this.card_number_lbl.Text = "Card number";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(6, 40);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(74, 13);
            this.name_lbl.TabIndex = 10;
            this.name_lbl.Text = "Name on card";
            // 
            // buy_button
            // 
            this.buy_button.Location = new System.Drawing.Point(285, 477);
            this.buy_button.Name = "buy_button";
            this.buy_button.Size = new System.Drawing.Size(127, 23);
            this.buy_button.TabIndex = 35;
            this.buy_button.Text = "Buy";
            this.buy_button.UseVisualStyleBackColor = true;
            this.buy_button.Click += new System.EventHandler(this.buy_button_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(16, 70);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(44, 13);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Name : ";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Location = new System.Drawing.Point(15, 98);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(51, 13);
            this.addresslbl.TabIndex = 7;
            this.addresslbl.Text = "Address :";
            // 
            // customeraddresstxtbox
            // 
            this.customeraddresstxtbox.Location = new System.Drawing.Point(70, 98);
            this.customeraddresstxtbox.Multiline = true;
            this.customeraddresstxtbox.Name = "customeraddresstxtbox";
            this.customeraddresstxtbox.Size = new System.Drawing.Size(231, 50);
            this.customeraddresstxtbox.TabIndex = 8;
            // 
            // nametxtbox
            // 
            this.nametxtbox.Enabled = false;
            this.nametxtbox.Location = new System.Drawing.Point(70, 67);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(231, 20);
            this.nametxtbox.TabIndex = 4;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 506);
            this.Controls.Add(this.nametxtbox);
            this.Controls.Add(this.customeraddresstxtbox);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.buy_button);
            this.Controls.Add(this.creditcart_groupbox);
            this.Controls.Add(this.groupBox1);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.creditcart_groupbox.ResumeLayout(false);
            this.creditcart_groupbox.PerformLayout();
            this.installment_groupbox.ResumeLayout(false);
            this.installment_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton cash_radiobutton;
        private System.Windows.Forms.RadioButton creditcard_radiobutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox creditcart_groupbox;
        private System.Windows.Forms.Label sixth_total_lbl;
        private System.Windows.Forms.Label installment_option_lbl;
        private System.Windows.Forms.Label twelve_total_lbl;
        private System.Windows.Forms.RadioButton first_installment_radiobutton;
        private System.Windows.Forms.Label third_total_lbl;
        private System.Windows.Forms.Label number_installment_lbl;
        private System.Windows.Forms.Label first_total_lbl;
        private System.Windows.Forms.Label monthly_payment_lbl;
        private System.Windows.Forms.Label twelve_payment_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label sixth_payment_lbl;
        private System.Windows.Forms.RadioButton third_installment_radiobutton;
        private System.Windows.Forms.Label third_payment_lbl;
        private System.Windows.Forms.RadioButton sixth_installment_radiobutton;
        private System.Windows.Forms.Label first_payment_lbl;
        private System.Windows.Forms.RadioButton twelve_installment_radiobutton;
        private System.Windows.Forms.TextBox name_txtbox;
        private System.Windows.Forms.Label cvv_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label card_number_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Button buy_button;
        private System.Windows.Forms.MaskedTextBox cardnumber_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox cvv_maskedTextBox;
        private System.Windows.Forms.MaskedTextBox expirydate_maskedTextBox;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label addresslbl;
        public System.Windows.Forms.TextBox customeraddresstxtbox;
        public System.Windows.Forms.TextBox nametxtbox;
        public System.Windows.Forms.GroupBox installment_groupbox;
    }
}