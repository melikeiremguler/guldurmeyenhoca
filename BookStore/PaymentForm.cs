using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class PaymentForm : Form
    {
        public CustomerForm customerform;
        private Database db;

        public PaymentForm()
        {
            InitializeComponent();

            Customer customer = find_customer();
            nametxtbox.Text = customer.name;

        }

        public void set_Form(CustomerForm customerform)
        {
            this.customerform = customerform;

        }

        private Customer find_customer()
        {
            db = Database.get_instance();
            db.read_customer("UserTable");
            Customer customer = null;
            for (int i = 0; i < db.CustomerList.Count; i++)
            {
                if (((Customer)db.CustomerList[i]).customerID == LoginForm.current_customer_id)
                {
                    customer = (Customer)db.CustomerList[i];
                    break;
                }
            }

            return customer;
        }

        private void buy_button_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(customeraddresstxtbox.Text) && cash_radiobutton.Checked)
            {

                MessageBox.Show("Please fill full in the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (creditcard_radiobutton.Checked &&
                (String.IsNullOrEmpty(nametxtbox.Text) || !expirydate_maskedTextBox.MaskFull || 
                !cardnumber_maskedTextBox.MaskFull || !cvv_maskedTextBox.MaskFull))
            {
                MessageBox.Show("Please fill full in the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DialogResult confirm_question = MessageBox.Show("Would you like to buy it?",
                                                        "The Confirmation",
                                      MessageBoxButtons.YesNoCancel,
                                      MessageBoxIcon.Question);
                if (confirm_question == DialogResult.Yes)
                {
                    InvoiceForm invoice_form = new InvoiceForm();

                    invoice_form.setPaymentForm(this);
                    invoice_form.Show();

                   
                    ShoppingCart shopping_cart = new ShoppingCart(LoginForm.current_customer_id, ref customerform.shopping_cart_list, 1);
                    

                    for (int i = 0; i < customerform.shopping_cart_list.Count; i++)
                    {

                        ItemToPurchase item = (ItemToPurchase)customerform.shopping_cart_list[i];
                        if (item.product.getId() == LoginForm.current_customer_id)
                        {
                            shopping_cart.removeProduct(item);
                            i--;
                        }

                        
                    }
                  
                    customerform.total_quantity = 0;
                    customerform.numberofproduct.Text = "0";
                    customerform.shopping_cart_list.Clear();

                    customerform.shoppingcart_datagridview.Rows.Clear();
                    customerform.shoppingcart_datagridview.Refresh();
                    customerform.total_price_textbox.Text = "0";
                }
            }
        }


        private void cash_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            creditcart_groupbox.Enabled = false;
        }

        private void creditcard_radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            creditcart_groupbox.Enabled = true;
            first_total_lbl.Text = customerform.total_price_textbox.Text;
            first_payment_lbl.Text = customerform.total_price_textbox.Text;
            third_total_lbl.Text = (Double.Parse(customerform.total_price_textbox.Text) + 10.0).ToString();
            third_payment_lbl.Text = Math.Round(((Double.Parse(customerform.total_price_textbox.Text) + 10.0) / 3.0), 2).ToString();
            sixth_total_lbl.Text = (Double.Parse(customerform.total_price_textbox.Text) + 20.0).ToString();
            sixth_payment_lbl.Text = Math.Round(((Double.Parse(customerform.total_price_textbox.Text) + 20.0) / 6.0), 2).ToString();
            twelve_total_lbl.Text = (Double.Parse(customerform.total_price_textbox.Text) + 30.0).ToString();
            twelve_payment_lbl.Text = Math.Round(((Double.Parse(customerform.total_price_textbox.Text) + 30.0) / 12.0), 2).ToString();
        }
       
    }
}
