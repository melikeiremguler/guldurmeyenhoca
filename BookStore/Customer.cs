using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   public class Customer:Observer
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        public string possword { get; set; }
        public int TotalCustomer { get; set; } = 0;
        public Customer(int id,string Name,string Email,string Username,string Password)
        {
            customerID = id;
            name = Name;
            email = Email;
            userName = Username;
            possword = Password;
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
        public void printCustomerDetails(int cutomerID)
        {
            Customer customer;
            CustumerList = read_customer(); //customer okuma fonsiyonunda okuma işlemi yapılır
            customer = customer_search(CustumerList, customerID);

            //cout kısmı ekle artık nere yazılcak bu detail ben bilmiyom

            

        }
        public void saveCustomer()
        {
            //textboxtan al ardından
            // Customer newCustomer= new Customer(//paremetreleri textboxdan al ); de
            //  Database database = Database.get_instance();
            // database.add_customer("INSERT INTO UserTable", newCustomer);//INSERT INTO UserTable(id,name,..)gibe de olabilir kontrol edilmeli!!



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
