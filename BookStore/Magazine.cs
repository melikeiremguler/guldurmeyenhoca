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

        public String Description { get; set; }
        public int Stok { get; set; }

<<<<<<< HEAD

        public enum Type { Actual, News, Sport, Computer, Technology }



        public Magazine(int id,string nm,double prc, Image img, Type Type, string Issue,string des,int stok) : base(nm, prc,img)
=======
        public Magazine(int id,string nm,double prc, string img_path, Type Type, string Issue) : base(id,nm, prc,img_path)
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754
        {
            issue = Issue;
            type = Type;
            Stok = stok;
            id = TotalMagazine;
            setId(id);
            TotalMagazine++;
            Description = des;
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
        public void setTotalMagazine(int i)
        {
             TotalMagazine=i;
        }
    }
}
