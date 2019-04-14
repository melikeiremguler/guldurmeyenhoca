using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    class Book:Product
    {
        public int ISBN { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public Image coverPagePicture { get; set; }

     

        public Book(string nm, double prc, int isbn, string Author, string Publisher, int Page, Image CoverPagePicture) : base(nm, prc)
        {
            ISBN = isbn;
            author = Author;
            publisher = Publisher;
            page = Page;
            coverPagePicture = CoverPagePicture;
        }
        public override void Print()
        {
            base.Print();
            Console.Write( " | " + ISBN + " | " + author + " | " + publisher + " | "  + page + Environment.NewLine);

        }
    }
}
