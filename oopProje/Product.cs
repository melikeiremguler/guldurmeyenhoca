using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopProje
{
    class Product
    {
        private static int TotalProduct = 0;
        private int Id;
        private string Name;
        private double Price;

        public Product(string nm, double prc)
        {
            Name = nm;
            Price = prc;
            Id = ++TotalProduct;
        }

        public int getId()
        {
            return Id;
        }

        public void setId(int id)
        {
            Id = id;
        }

        public string getName()
        {
            return Name;
        }

        public void setName(ref string nm)
        {
            Name = nm;
        }


        public double getPrice()
        {
            return Price;
        }

        public void setPrice(double price)
        {
            Price = price;

        }
        public virtual void Print()
        {
            Console.Write("| " + getId() + " | " + getName() + " | " + getPrice());

        }
    }
}
