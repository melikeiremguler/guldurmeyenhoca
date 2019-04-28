using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
   public class Customer:Observer
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        
        public string password { get; set; }
        public string Address { get; set; }
        public static int TotalCustomer { get; set; } = 0;
        public Customer(int id,string Name,string Email,string Username,string Password,string address)
        {
            customerID = id;
            name = Name;
            email = Email;
            userName = Username;
            password = Password;
            Address = address;
            TotalCustomer++;

        }
        List<Customer> CustumerList = new List<Customer>();
        public List<Customer> read_customer()
        {
            Database database = Database.get_instance();
            CustumerList = database.read_customer("UserTable"); //okunan list çekilir

            return CustumerList;
        }
        public Customer customer_search(List<Customer> customers, int searchID)
        {
            foreach (Customer customer in customers)
            {
                if (customer.customerID == searchID)
                {
                    return customer;
                }
            }
            return null;
        }
        public DataTable printCustomerDetails()
        {

         //customer okuma fonsiyonunda okuma işlemi yapılır
                                            // customer = customer_search(CustumerList, customerID);
            Database database = Database.get_instance();
            CustumerList = read_customer();

            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6] { new DataColumn("Id", typeof(Int32)), new DataColumn("Name", typeof(string)), new DataColumn("Email", typeof(String)), new DataColumn("UserName", typeof(String)), new DataColumn("Passwword", typeof(String)), new DataColumn("Address", typeof(string)) });
            for (int i = 0; i < database.CustomerList.Count; i++)
            {
                dt.Rows.Add(database.CustomerList[i].customerID, database.CustomerList[i].name, database.CustomerList[i].email, database.CustomerList[i].userName, database.CustomerList[i].password, database.CustomerList[i].Address);
            }
           

        
            return dt;


        }
        public void printCustomerPurchases()
        {

            //sqlite dan çekilcek
            


        }

        public override void Update()
        {
           
            Console.WriteLine("Stok is changed.");
            Console.ReadLine();
        
        }
    }
}
