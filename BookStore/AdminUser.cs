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
        private static AdminUser admin;
        public AdminUser(int id, string Name, string Email, string Username, string Password,string Address) : base(id, Name, Email, Username, Password,Address)
        {
         
        }
        public static AdminUser get_instance() //singlaton kullanımı
        {
            if (admin == null)
            {
                admin = new AdminUser(0,"tiv","tiv","tiv","tiv","tiv");

            }
            return admin;
        }
        public bool IsAdmin(){ return true; }
        public void addCustomer(int id,string name,string email,string username,string password,string address)
        {
            Customer customer = new Customer(id, name, email, userName, password,address);
            Database database = Database.get_instance();
            database.add_customer("INSERT INTO UserTable", customer);
        }
        public void addNewBook(int id,string nm, double prc, Image CoverPagePicture, int isbn, string Author, string Publisher, int Page,string des,int stok)
        {
            Book book = new Book(id,nm,prc, isbn, Author, Publisher, Page, CoverPagePicture, des,stok);
            Database database = Database.get_instance();
            database.add_book("INSERT INTO BookTable(Id,Name,Price,Image,ISBN,Author,Publisher,Page,Description,Stock) values(@Id,@Name,@Price,@Image,@ISBN,@Author,@Publisher,@Page,@Description,@Stock)", book);
           
        }
        public void addNewMagazine(int id, string nm, double prc, Image img, Magazine.Type type, string Issue,string des,int stok)
        {

            Magazine magazine = new Magazine(id,nm,prc,img, type,Issue,des,stok);

            Database database = Database.get_instance();
            database.add_magazine("INSERT INTO MagazineTable(Id,Name,Price,Image,Type,Issue,Description,Stock) values(@Id,@Name,@Price,@Image,@Type,@Issue,@Description,@Stock)", magazine);//parametreler databasedeki sıraya göre alındı.
        } 
        public void addNewMusicCD(int id,string nm, double prc ,Image img,string Singer, MusicCD.Type type,int stok)
        {
            MusicCD musicCD = new MusicCD(id,nm,prc,img,Singer,type,stok);
            Database database = Database.get_instance();
            database.add_musiccd("INSERT INTO MusicCDTable(Id,Name,Price,Image,Singer,Type,Stock) values(@Id,@Name,@Price,@Image,@Singer,@Type,@Stock)", musicCD);
        }

       
    }
    

}
