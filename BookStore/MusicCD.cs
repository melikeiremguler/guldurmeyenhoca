using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
   
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
        public override void Print()
        {
            base.Print();
            Console.Write(" | " + singer + " | " + type +  Environment.NewLine);

        }
        public int getTotalCd()
        {
            return TotalCD;
        }
        public void setTotalCd(int t)
        {
           TotalCD = t;
        }
    }
}
