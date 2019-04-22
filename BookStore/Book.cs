using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
<<<<<<< HEAD
    public class Book:Product
=======
   public class Book:Product
>>>>>>> 4cd6dc87670d09d883970ff563e5ae470d93c539
    {
        public int ISBN { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public static int TotalBook { get; set; } = 0;


        public Book(int id,string nm, double prc, Image CoverPagePicture,int isbn, string Author, string Publisher, int Page) : base(id,nm, prc,CoverPagePicture)
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
