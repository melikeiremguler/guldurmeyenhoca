using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public enum type { Romance, HardRock, Country }
    class MusicCD:Product
    {
        public String singer { get; set; }
        public type type { get; set; }

        public static int TotalCD { get; set; } = 0;

        public MusicCD(string nm, double prc, string Singer, type Type) : base(nm, prc)
        {
            singer = Singer;
            type = Type;
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
