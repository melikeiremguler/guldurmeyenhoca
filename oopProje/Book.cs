using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    class Book
    {
        public int ISBN { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public Image coverPagePicture { get; set; }

        public Book(int isbn,string Author,string Publisher,int Page,Image CoverPagePicture)
        {
            ISBN = isbn;
            author = Author;
            publisher = Publisher;
            page = Page;
            coverPagePicture = CoverPagePicture;

        }
    }
}
