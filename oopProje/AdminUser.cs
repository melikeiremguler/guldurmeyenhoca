using System;
using System.Collections.Generic;
using System.Drawing;
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
        public void addCustomer(int id,string name,string email,string username,string password)
        {
            Customer customer = new Customer(id, name, email, userName, password);
        }
        public void addNewBook(int isbn, string Author, string Publisher, int Page, Image CoverPagePicture)
        {
            Book book = new Book(isbn, Author, Publisher, Page, CoverPagePicture);
        }
        public void addNewMagazine(string Issue,Type type)
        {
            Magazine magazine = new Magazine(Issue,type);
        }
        public void addNewMusicCD(string singer,type type)
        {
            MusicCD musicCD = new MusicCD(singer, type);
        }

    }
    

}
