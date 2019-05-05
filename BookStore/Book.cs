using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /*! \class Book
     *  \brief It is book class.
     *  \details it is derived from product class
     */
    public class Book:Product

    {
       
        public int ISBN { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public int page { get; set; }
        public string Description { get; set; }
        public int Stok { get; set; }
        public static int TotalBook { get; set; } = 0;


        public Book(int id,string nm, double prc, int isbn, string Author, string Publisher, int Page, string CoverPagePicture,string des,int stok) : base(id,nm, prc,CoverPagePicture)

        {
            ISBN = isbn;
            author = Author;
            publisher = Publisher;
            page = Page;
            Stok = stok;
            id = TotalBook;
            setId(id);
            TotalBook++;
            Description = des;
            
        }
        /*! \fn int getTotalBook()
         *  \brief A int function.
         *  \details It is used to return total book
         *  \return int
        */
        public int getTotalBook()
        {
            return TotalBook;
        }

        /*! \fn void setTotalBook(int t)
         *  \brief A void function.
         *  \details It is used to set number of total book
         *  \param t (int) number of total book
         *  \return void
        */
        public void setTotalBook(int t)
        {
            TotalBook = t ;
        }

        /*! \fn override void Print()
         *  \brief A void function.
         *  \details It is overrided from Product class.It is used to print information of Book 
         *  \return void
        */
        public override void Print()
        {
            base.Print();
            Console.Write( " | " + ISBN + " | " + author + " | " + publisher + " | "  + page + Environment.NewLine);

        }
    }
}
