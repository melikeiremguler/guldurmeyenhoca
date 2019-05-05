using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /*! \class AdminUser
     *  \brief It is admin user class.
     *  \details it is derived from customer class
     */
    class AdminUser :Customer
    {
        
        public string address { get; set; }
        private static AdminUser admin;
        public AdminUser(int id, string Name, string Email, string Username, string Password,string Address) : base(id, Name, Email, Username, Password,Address)
        {
         
        }
        /*! \fn static AdminUser get_instance()
        *  \brief A AdminUser function.
        *  \details It is used to create only one AdminUser object by using Singleton Pattern.
        *  \return AdminUser
       */
        public static AdminUser get_instance() //singleton kullanımı
        {
            if (admin == null)
            {
                admin = new AdminUser(0,"tiv","tiv","tiv","tiv","tiv");

            }
            return admin;
        }
        /*! \fn bool IsAdmin()
        *  \brief A bool function.
        *  \details It is used to check user is whether admin or not.
        *  \return bool
       */
        public bool IsAdmin(){ return true; }

        /*! \fn void addCustomer(int id,string name,string email,string username,string password,string address)
         *  \brief A void function.
         *  \details It is used to add customer into user table in database.
         *  \param id (int) id of customer 
         *  \param name (string) name of customer 
         *  \param email (string) email of customer
         *  \param username (string) username of customer
         *  \param password (string) password of customer
         *  \param address (string) address of customer
         *  \return void
        */
        public void addCustomer(int id,string name,string email,string username,string password,string address)
        {
            Customer customer = new Customer(id, name, email, userName, password,address);
            Database database = Database.get_instance();
            database.add_customer("INSERT INTO UserTable", customer);
        }

        /*! \fn void addNewBook(int id,string nm, double prc, string CoverPagePicture, int isbn, string Author, string Publisher, int Page,string des,int stok)
         *  \brief A void function.
         *  \details It is used to add book into book table in database.
         *  \param id (int) id of book 
         *  \param nm (string) name of book 
         *  \param prc (double) price of book
         *  \param CoverPagePicture (string) Cover Page Picture's directory of book
         *  \param isbn (string) isbn of book
         *  \param Author (string) Author of book
         *  \param Publisher (string) Publisher of book
         *  \param Page (int) Page of Book
         *  \param des (string) Description of book
         *  \param stok (int) Stock Information of book
         *  \return void 
        */
        public void addNewBook(int id,string nm, double prc, string CoverPagePicture, int isbn, string Author, string Publisher, int Page,string des,int stok)
        {
            Book book = new Book(id,nm,prc, isbn, Author, Publisher, Page, CoverPagePicture, des,stok);

            Database database = Database.get_instance();
            database.add_book("INSERT INTO BookTable(Id,Name,Price,Image,ISBN,Author,Publisher,Page,Description,Stock) values(@Id,@Name,@Price,@Image,@ISBN,@Author,@Publisher,@Page,@Description,@Stock)", book);
           
        }
        /*! \fn void addNewMagazine(int id, string nm, double prc, string img, Magazine.Type type, string Issue,string des,int stok)
         *  \brief A void function.
         *  \details It is used to add magazine into magazine table in database.
         *  \param id (int) id of magazine 
         *  \param nm (string) name of magazine 
         *  \param prc (double) price of magazine
         *  \param img (string) Cover Page Picture's directory of magazine
         *  \param type (Magazine.Type) type of magazine
         *  \param Issue (string) Issue of magazine
         *  \param des (string) Description of magazine
         *  \param stok (int) Stock Information of magazine
         *  \return void 
        */
        public void addNewMagazine(int id, string nm, double prc, string img, Magazine.Type type, string Issue,string des,int stok)
        {

            Magazine magazine = new Magazine(id,nm,prc,img, type,Issue,des,stok);


            Database database = Database.get_instance();
            database.add_magazine("INSERT INTO MagazineTable(Id,Name,Price,Image,Type,Issue,Description,Stock) values(@Id,@Name,@Price,@Image,@Type,@Issue,@Description,@Stock)", magazine);//parametreler databasedeki sıraya göre alındı.
        }

        /*! \fn void addNewMusicCD(int id,string nm, double prc ,string img,string Singer, MusicCD.Type type,int stok)
         *  \brief A void function.
         *  \details It is used to add musiccd into musiccd table in database.
         *  \param id (int) id of musiccd 
         *  \param nm (string) name of musiccd 
         *  \param prc (double) price of musiccd
         *  \param img (string) Cover Page Picture's directory of musiccd
         *  \param type (MusicCD.Type) type of musiccd
         *  \param stok (int) Stock Information of musiccd
         *  \return void 
        */
        public void addNewMusicCD(int id,string nm, double prc ,string img,string Singer, MusicCD.Type type,int stok)
        {
            MusicCD musicCD = new MusicCD(id,nm,prc,img,Singer,type,stok);

            Database database = Database.get_instance();
            database.add_musiccd("INSERT INTO MusicCDTable(Id,Name,Price,Image,Singer,Type,Stock) values(@Id,@Name,@Price,@Image,@Singer,@Type,@Stock)", musicCD);
        }

       
    }
    

}
