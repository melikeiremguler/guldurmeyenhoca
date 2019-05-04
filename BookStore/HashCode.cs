using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
  public  class HashCode
    {
        public string hashCode;

       public  HashCode(string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var md5 = new MD5CryptoServiceProvider();
            var md5data = md5.ComputeHash(data);
            ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();

            hashCode = aSCIIEncoding.GetString(md5data);
        }

    }
}
