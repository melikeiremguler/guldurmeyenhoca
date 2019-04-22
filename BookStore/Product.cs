﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Product
    {
        private List<Observer> observers = new List<Observer>();

        public static int TotalProduct { get; set; } = 0;
        private int Id;
        private string Name;
        private double Price;
        
        public Product(string nm, double prc)
        {
            Name = nm;
            Price = prc;
            Id = ++TotalProduct;
            
        }
        public int getTotal()
        {
            return TotalProduct;
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
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        private void Notify()
        {
            // Herhangi bir değişiklik olduğunda gözlemleyicilerimizin Update metotunu tetikleterek istenilen aksiyonu gerçekleştirebiliriz. Örneğin: Kullanıcılara e-posta atmak gibi düşünebilirsiniz.
            observers.ForEach(o => { o.Update(); });
        }

        public void ChangeStock()
        {
           // ... stok değiştirilme işlemleri
            // Stok değiştirildiğinde gözlemcilerimize bildiriyoruz.
            this.Notify();
        }
    }
}