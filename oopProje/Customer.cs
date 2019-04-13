using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    class Customer
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string possword { get; set; }
        public Customer(int id,string Name,string Email,string Username,string Password)
        {
            customerID = id;
            name = Name;
            email = Email;
            userName = Username;
            possword = Password;

        }
        public void printCustomerDetails() { }
        public void saveCustomer() { }
        public void printCustomerPurchases() { }
    }
}
