﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
<<<<<<< HEAD
    public class Product
=======
     public class Product
>>>>>>> 4cd6dc87670d09d883970ff563e5ae470d93c539
    {
        private List<Observer> observers = new List<Observer>();

        public static int idcounter { get; set; } = 0; //eğer kodda bi şey patlarsa total ile ilgili olabilir
        private int Id;
        private string Name;
        private double Price;
        public Image image { get; set; }
        
        public Product(int id,string nm, double prc,Image img)
        {
            Name = nm;
            Price = prc;
            Id = ++idcounter;
            image = img;
            
        }
        public int getTotal()
        {
            return idcounter;
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
