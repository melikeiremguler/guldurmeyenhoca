﻿using System;
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
            Book book = new Book(id,nm,prc, CoverPagePicture, isbn, Author, Publisher, Page);
            Database database = Database.get_instance();
            database.add_book("INSERT INTO BookTable", book);
        }
        public void addNewMagazine(int id, string nm, double prc, Image img, string Issue, Type Type)
        {
            Magazine magazine = new Magazine(id,nm,prc,img,Issue,Type);
            Database database = Database.get_instance();
            database.add_magazine("INSERT INTO MagazineTable", magazine);
        } 
        public void addNewMusicCD(int id,string nm, double prc ,Image img,string Singer, type Type)
        {
            MusicCD musicCD = new MusicCD(id,nm,prc,img,Singer, Type);
            Database database = Database.get_instance();
            database.add_musiccd("INSERT INTO UserTable", musicCD);
        }

    }
    

}
