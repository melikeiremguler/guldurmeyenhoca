using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class ShoppingCart
    {
        public int customerID { get; set; }
        public ArrayList itemsToPurchase { get; set; }
        public double paymentAmount { get; set; }
        public enum paymentType { cash, creditcard }
        public ShoppingCart(int id,ArrayList items,double amount) //contructor
        {
            customerID = id;
            paymentAmount = amount;
            itemsToPurchase = items;

        }
        public void printProducts()
        {
            
        }
        public void addProduct(ItemToPurchase item)
        {
            itemsToPurchase.Add(item);
        }
        public void removeProduct( ItemToPurchase item)
        {
            itemsToPurchase.Remove(item);
        }
        public void placeOrder() { }//fatura gönderme
        public void cancelOrder() { }//sms gönderme
        public void endInvoidcebyEmail() { }
    }
}
