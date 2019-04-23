using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ItemToPurchase
    {
        
        public Product product { get; set; }
        public int quantity { get; set; }
        public ItemToPurchase(Product Product,int Quantity)
        {
            product = Product;
            quantity = Quantity;
        }
    }
}
