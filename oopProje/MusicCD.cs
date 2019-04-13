using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    class MusicCD
    {
        public String singer { get; set; }
        public enum type { Romance, HardRock, Country }

        public MusicCD(string Singer, type Type)
        {
            singer = Singer;
            //Type = Type;
        }
    }
}
