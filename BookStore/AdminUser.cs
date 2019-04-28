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
<<<<<<< HEAD
        public void addNewBook(int id,string nm, double prc, Image CoverPagePicture, int isbn, string Author, string Publisher, int Page,string des,int stok)
        {
            Book book = new Book(id,nm,prc, isbn, Author, Publisher, Page, CoverPagePicture, des,stok);
=======
        public void addNewBook(int id,string nm, double prc, string CoverPagePicture_path, int isbn, string Author, string Publisher, int Page)
        {
            Book book = new Book(id,nm,prc, isbn, Author, Publisher, Page, CoverPagePicture_path);
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754
            Database database = Database.get_instance();
            database.add_book("INSERT INTO BookTable(Id,Name,Price,Image,ISBN,Author,Publisher,Page,Description,Stock) values(@Id,@Name,@Price,@Image,@ISBN,@Author,@Publisher,@Page,@Description,@Stock)", book);
           
        }
<<<<<<< HEAD
        public void addNewMagazine(int id, string nm, double prc, Image img, Magazine.Type type, string Issue,string des,int stok)
        {

            Magazine magazine = new Magazine(id,nm,prc,img, type,Issue,des,stok);
=======
        public void addNewMagazine(int id, string nm, double prc, string img_path, Magazine.Type type, string Issue)
        {

            Magazine magazine = new Magazine(id,nm,prc,img_path, type,Issue);
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754

            Database database = Database.get_instance();
            database.add_magazine("INSERT INTO MagazineTable(Id,Name,Price,Image,Type,Issue,Description,Stock) values(@Id,@Name,@Price,@Image,@Type,@Issue,@Description,@Stock)", magazine);//parametreler databasedeki sıraya göre alındı.
        } 
<<<<<<< HEAD
        public void addNewMusicCD(int id,string nm, double prc ,Image img,string Singer, MusicCD.Type type,int stok)
        {
            MusicCD musicCD = new MusicCD(id,nm,prc,img,Singer,type,stok);
=======
        public void addNewMusicCD(int id,string nm, double prc ,string img_path,string Singer, MusicCD.Type type)
        {
            MusicCD musicCD = new MusicCD(id,nm,prc,img_path,Singer,type);
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754
            Database database = Database.get_instance();
            database.add_musiccd("INSERT INTO MusicCDTable(Id,Name,Price,Image,Singer,Type,Stock) values(@Id,@Name,@Price,@Image,@Singer,@Type,@Stock)", musicCD);
        }

       
    }
    

}
