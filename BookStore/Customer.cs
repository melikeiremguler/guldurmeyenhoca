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
    /*! \class Customer
     *  \brief It is customer class.
     *  \details it is derived from Observer class
     */
    public class Customer:Observer
    {
        public int customerID { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
        
        public string password { get; set; }
        public string Address { get; set; }
        public static int TotalCustomer { get; set; } = 0;

        List<Customer> CustumerList = new List<Customer>();

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

        /*! \fn List<Customer> read_customer()
        *  \brief A List<Customer> function.
        *  \details It is used to read data about customer from database.
        *  \return List<Customer>
       */
        public List<Customer> read_customer()
        {
            Database database = Database.get_instance();
            CustumerList = database.read_customer("UserTable"); //okunan list çekilir

            return CustumerList;
        }

        /*! \fn Customer customer_search(List<Customer> customers, int searchID)
        *  \brief A Customer function.
        *  \details It is used to search customer.
        *  \param customers (List<Customer>) customer list.
        *  \param searchID (int) id that is wanted to search of customer 
        *  \return List<Customer>
       */
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

        /*! \fn DataTable printCustomerDetails()
        *  \brief A DataTable function.
        *  \details It is used to print customer details.
        *  \return DataTable
       */
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

        /*! \fn override void Update()
        *  \brief A void function.
        *  \details It is overrided from Observer and It is used to send message when stock is updated.
        *  \return void
       */
        public override void Update()
        {
           
            Console.WriteLine("Stok is changed.");
            Console.ReadLine();
        
        }
    }
}
