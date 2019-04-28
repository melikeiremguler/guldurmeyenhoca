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

<<<<<<< HEAD
        public MusicCD(int id,string nm,double prc, Image img , string Singer, Type type,int stok) : base(nm, prc,img)
=======
        public MusicCD(int id,string nm,double prc, string img_path , string Singer, Type type) : base(id,nm, prc,img_path)
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754
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
