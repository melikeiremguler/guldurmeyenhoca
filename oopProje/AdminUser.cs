using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
  class AdminUser:Customer
    {
        //public int customerID { get; set; }
        //public string name { get; set; }
        //public string email { get; set; }
        //public string userName { get; set; }
        //public string possword { get; set; }
        public string address { get; set; }
        public AdminUser(int id, string Name, string Email, string Username, string Password,string Address) : base(id, Name, Email, Username, Password)
        {
            address = Address;
        }
        public bool IsAdmin(){ return true; }
        public void addCustomer() { }
        public void addNewBook() { }
        public void addNewMagazine() { }
        public void addNewMusicCD() { }

    }
    

}
