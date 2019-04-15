using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    class Customer:Observer
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
        public void printCustomerDetails()
        {
            

            //  Implemantasyoonu yapppppppppppppppppppp


        }
        public void saveCustomer()
        {


            //  Implemantasyoonu yapppppppppppppppppppp


        }
        public void printCustomerPurchases()
        {


            //  Implemantasyoonu yapppppppppppppppppppp


        }

        public override void Update()
        {
           
            Console.WriteLine("Stok is changed.");
            Console.ReadLine();
        
        }
    }
}
