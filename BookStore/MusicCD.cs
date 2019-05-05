using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /*! \class MusicCD
     *  \brief It is MusicCD class.
     *  \details it is derived from Product class
     */
    public class MusicCD:Product
    {
        public enum Type { Romance, HardRock, Country }
        public String singer { get; set; }
        public Type type { get; set; }
        public int Stok { get; set; }
        public static int TotalCD { get; set; } = 0;


        public MusicCD(int id,string nm,double prc, string img , string Singer, Type type,int stok) : base(id,nm, prc,img)
        {
            singer = Singer;
            this.type = type;
            Stok = stok;
            id = TotalCD;
            setId(id);
            TotalCD++;
        }
        /*! \fn override void Print()
        *  \brief A void function.
        *  \details It is overrided from Product class.It is used to print information of MusicCD. 
        *  \return void
       */
        public override void Print()
        {
            base.Print();
            Console.Write(" | " + singer + " | " + type + Environment.NewLine);

        }
        /*! \fn int getTotalCd()
         *  \brief A int function.
         *  \details It is used to return total musicCd.
         *  \return int
         */
        public int getTotalCd()
        {
            return TotalCD;
        }
        /*! \fn void setTotalCd(int t)
        *  \brief A void function.
        *  \details It is used to set total musicCd.
        *  \return void
        */
        public void setTotalCd(int t)
        {
           TotalCD = t;
        }
    }
}
