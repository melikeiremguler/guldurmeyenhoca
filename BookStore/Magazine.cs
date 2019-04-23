using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
  
    public class Magazine:Product
    {
        public Type type { get; set; }
        public string issue { get; set; }

        public static int TotalMagazine{ get; set; } = 0;

        public enum Type { Actual, News, Sport, computer, technology }

        public Magazine(int id,string nm,double prc, Image img, string Issue, Type Type) : base(id,nm, prc,img)
        {
            issue = Issue;
            type = Type;
            TotalMagazine++;
        }
        public override void Print()
        {
            base.Print();
            Console.Write(" | " + type + " | " + issue + Environment.NewLine);

        }
        public int getTotalMagazine()
        {
            return TotalMagazine;
        }
    }
}
