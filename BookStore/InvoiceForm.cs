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
    /*! \class InvoiceForm
     *  \brief It is Invoice Form class.
     *  \details it is derived from Form class
    */
    public partial class InvoiceForm : Form
    {
        
        private bool mouseDown;
        private Point lastLocation;
       
        public InvoiceForm()
        {
             InitializeComponent();
        }

        /*! \fn void setPaymentForm(PaymentForm paymentForm)
        *  \brief A set Payment Form.
        *  \details It is used to make operation on PaymentForm.
        *  \param paymentForm it is an PaymentForm object.
        *  \return void
        */
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

        /*! \fn void exit_lbl_Click(object sender, EventArgs e)
       *  \brief A click listener function.
       *  \details It is used to exit Invoice Form.
       *  \param sender it is an object.
       *  \param e it is EventArgs object.
       *  \return void
       */
        private void exit_lbl_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*! \fn void InvoiceForm_MouseDown(object sender, MouseEventArgs e)
          *  \brief A mouse down listener function.
          *  \details It is used to move invoice form.
          *  \param sender it is an object.
          *  \param e it is MouseEventArgs object.
          *  \return void
        */
        private void InvoiceForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        /*! \fn void InvoiceForm_MouseMove(object sender, MouseEventArgs e)
          *  \brief A mouse move listener function.
          *  \details It is used to move invoice form.
          *  \param sender it is an object.
          *  \param e it is MouseEventArgs object.
          *  \return void
        */
        private void InvoiceForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        /*! \fn void InvoiceForm_MouseUp(object sender, MouseEventArgs e)
          *  \brief A mouse move listener function.
          *  \details It is used to move invoice form.
          *  \param sender it is an object.
          *  \param e it is MouseEventArgs object.
          *  \return void
        */
        private void InvoiceForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /*! \fn void ok_button_Click(object sender, EventArgs e)
          *  \brief A click listener function.
          *  \details It is used to call screenshot function and confirm invoice.
          *  \param sender it is an object.
          *  \param e it is EventArgs object.
          *  \return void
        */
        private void ok_button_Click(object sender, EventArgs e)
        {
            screenshotForm();

            this.Close();
        }

        /*! \fn void screenshotForm()
          *  \brief A screen shot function.
          *  \details It is used to take invoice screen shot then send email.
          *  \return void
        */
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
