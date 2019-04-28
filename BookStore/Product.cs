using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore { 

    public class Product

    {
        private List<Observer> observers = new List<Observer>();

        public static int TotalProduct { get; set; } = 0; //eğer kodda bi şey patlarsa total ile ilgili olabilir
        private int Id;
        private string Name;
        private double Price;
        public string image_path { get; set; }
        
<<<<<<< HEAD
        public Product(string nm, double prc,Image img)
        {
            Name = nm;
            Price = prc;
            TotalProduct++;
            image = img;
=======
        public Product(int id,string nm, double prc,string img_path)
        {
            Name = nm;
            Price = prc;
            Id = id;
            image_path = img_path;
>>>>>>> c79f436d15f902ebd0b5d835f1c772eb39a57754
            
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
