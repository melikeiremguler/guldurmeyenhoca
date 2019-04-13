using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    public enum Type { Actual, News, Sport, computer, technology }
    class Magazine
    {
        public Type type { get; set; }
        public string issue { get; set; }
       
        public Magazine(string Issue, Type Type)
        {
            issue = Issue;
            type = Type;
        }
    }
}
