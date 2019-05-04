using System;
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
    public partial class InvoiceForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
       
        public InvoiceForm()
        {
           
            InitializeComponent();
            

        }

        public void setPaymentForm(PaymentForm paymentForm)
        {
            customernamelbl.Text = paymentForm.nametxtbox.Text;
            customeraddresslbl.Text = paymentForm.customeraddresstxtbox.Text;
            customertotalpricelbl.Text = paymentForm.customerform.total_price_textbox.Text;
            //to assign clicked installment radiobutton
            RadioButton checkedButton = paymentForm.installment_groupbox.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            if (checkedButton != null)
            {
                customerinstallmentlbl.Text = checkedButton.Text;
            }

            for (int i = 0; i < paymentForm.customerform.shopping_cart_list.Count; i++)
            {

                ItemToPurchase item = (ItemToPurchase)paymentForm.customerform.shopping_cart_list[i];
                if (item.product.getId() == LoginForm.current_customer_id)
                {
                    ListViewItem lv_item = new ListViewItem(item.product.getName());
                    lv_item.SubItems.Add(item.quantity.ToString());
                    lv_item.SubItems.Add(item.product.getPrice().ToString());
                    lv_item.SubItems.Add(item.total_price.ToString());

                    productlistview.Items.Add(lv_item);
                }
            }
            paymentForm.Close();
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InvoiceForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void InvoiceForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void InvoiceForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            screenshotForm();

            this.Close();
        }
        private void screenshotForm()
        {
            var frm = InvoiceForm.ActiveForm;
            using (var bmp = new Bitmap(frm.Width, frm.Height))
            {
                frm.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                bmp.Save(Application.StartupPath + "screenshot.jpeg");

                Email email = new Email();


            }
        }
    }

}
