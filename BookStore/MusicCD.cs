using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public enum type { Romance, HardRock, Country }
    public class MusicCD:Product
    {
        public String singer { get; set; }
        public type type { get; set; }

        public static int TotalCD { get; set; } = 0;

        public MusicCD(int id,string nm,double prc, Image img , string Singer, type Type) : base(id,nm, prc,img)
        {
            singer = Singer;
            type = Type;
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
    }
}
