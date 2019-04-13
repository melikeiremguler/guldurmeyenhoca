using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    public enum type { Romance, HardRock, Country }
    class MusicCD
    {
        public String singer { get; set; }
        public type type { get; set; }

        public MusicCD(string Singer, type Type)
        {
            singer = Singer;
            type =Type;
        }
    }
}
