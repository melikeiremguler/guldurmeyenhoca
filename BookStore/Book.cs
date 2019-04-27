﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{


   public class Book:Product

    {
        public int ISBN { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public static int TotalBook { get; set; } = 0;


        public Book(int id,string nm, double prc, int isbn, string Author, string Publisher, int Page, string CoverPagePicture_path) : base(id,nm, prc,CoverPagePicture_path)
        {
            ISBN = isbn;
            author = Author;
            publisher = Publisher;
            page = Page;
            TotalBook++;
           
            
        }
        public int getTotalBook()
        {
            return TotalBook;
        }
        public override void Print()
        {
            base.Print();
            Console.Write( " | " + ISBN + " | " + author + " | " + publisher + " | "  + page + Environment.NewLine);

        }
    }
}
