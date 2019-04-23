using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
  class AdminUser:Customer
    {
        
        public string address { get; set; }
        public AdminUser(int id, string Name, string Email, string Username, string Password,string Address) : base(id, Name, Email, Username, Password)
        {
            address = Address;
        }
        public bool IsAdmin(){ return true; }
        public void addCustomer(int id,string name,string email,string username,string password)
        {
            Customer customer = new Customer(id, name, email, userName, password);
            Database database = Database.get_instance();
            database.add_customer("INSERT INTO UserTable", customer);
        }
        public void addNewBook(int id,string nm, double prc, Image CoverPagePicture, int isbn, string Author, string Publisher, int Page)
        {
            Book book = new Book(id,nm,prc, isbn, Author, Publisher, Page, CoverPagePicture);
            Database database = Database.get_instance();
            database.add_book("INSERT INTO BookTable", book);
        }
        public void addNewMagazine(int id, string nm, double prc, Image img, Magazine.Type type, string Issue)
        {
            Magazine magazine = new Magazine(id,nm,prc,img,type, Issue);
            Database database = Database.get_instance();
            database.add_magazine("INSERT INTO MagazineTable", magazine);
        } 
        public void addNewMusicCD(int id,string nm, double prc ,Image img,string Singer, MusicCD.Type type)
        {
            MusicCD musicCD = new MusicCD(id,nm,prc,img,Singer,type);
            Database database = Database.get_instance();
            database.add_musiccd("INSERT INTO UserTable", musicCD);
        }

    }
    

}
