using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    public enum Type { Actual, News, Sport, computer, technology }
    class Magazine:Product
    {
        public Type type { get; set; }
        public string issue { get; set; }

        public static int TotalMagazine{ get; set; } = 0;


        public Magazine(string nm, double prc, string Issue, Type Type) : base(nm, prc)
        {
            issue = Issue;
            type = Type;
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
