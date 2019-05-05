using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /*! \class Magazine
      * \brief It is Magazine class.
      * \details it is derived from Product class
      */
    public class Magazine:Product
    {
        public Type type { get; set; }
        public string issue { get; set; }

        public static int TotalMagazine{ get; set; } = 0;

        public String Description { get; set; }
        public int Stok { get; set; }

        public enum Type { Actual, News, Sport, Computer, Technology }

        public Magazine(int id,string nm,double prc, string img, Type Type, string Issue,string des,int stok) : base(id,nm, prc,img)
        {
            issue = Issue;
            type = Type;
            Stok = stok;
            id = TotalMagazine;
            setId(id);
            TotalMagazine++;
            Description = des;
        }

        /*! \fn override void Print()
         *  \brief A void function.
         *  \details It is overrided from Product class.It is used to print information of Magazine. 
         *  \return void
        */
        public override void Print()
        {
            base.Print();
            Console.Write(" | " + type + " | " + issue + Environment.NewLine);

        }
        /*! \fn int getTotalMagazine()
        *  \brief A int function.
        *  \details It is used to return total magazine.
        *  \return int
        */
        public int getTotalMagazine()
        {
            return TotalMagazine;
        }

        /*! \fn void setTotalMagazine(int i)
         *  \brief A void function.
         *  \details It is used to set number of total magazine.
         *  \param i (int) number of total magazine.
         *  \return void
        */
        public void setTotalMagazine(int i)
        {
             TotalMagazine=i;
        }
    }
}
