using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore {

    /*! \class Product
    *   \brief It is Product class.
    */
    public class Product
    {
        private List<Observer> observers = new List<Observer>();

        public static int TotalProduct { get; set; } = 0; //eğer kodda bi şey patlarsa total ile ilgili olabilir
        private int Id;
        int a;
        private string Name;
        private double Price;
        public string image_path { get; set; }
        

        public Product(int id,string nm, double prc,string img_path)
        {
            Name = nm;
            Price = prc;
            Id = id;
            image_path = img_path;

        }

        /*! \fn  int getTotal()
        *  \brief A int return total function.
        *  \details It is used to return total product.
        *  \return int
        */
        public int getTotal()
        {
            return TotalProduct;
        }

        /*! \fn int getId()
        *  \brief A int return id function.
        *  \details It is used to return product id.
        *  \return int
        */
        public int getId()
        {
            return Id;
        }

        /*! \fn void setId(int id)
       *  \brief A void set id function.
       *  \details It is used to set new product id.
       *  \param id (int) new product id.
       *  \return void
       */
        public void setId(int id)
        {
            Id = id;
        }

        /*! \fn int getName()
        *  \brief A string return name function.
        *  \details It is used to return product name.
        *  \return string
        */
        public string getName()
        {
            return Name;
        }

        /*! \fn void setName(ref string nm)
        *  \brief A string set name function.
        *  \details It is used to set new product name.
        *  \param nm (string) new product name.
        *  \return void
        */
        public void setName(ref string nm)
        {
            Name = nm;
        }

        /*! \fn double getPrice()
       *  \brief A double return price function.
       *  \details It is used to return product price.
       *  \return double
       */
        public double getPrice()
        {
            return Price;
        }

        /*! \fn void setPrice(double price)
       *  \brief A string set price function.
       *  \details It is used to set new product price.
       *  \param price (double) new price.
       *  \return void
       */
        public void setPrice(double price)
        {
            Price = price;

        }

        /*! \fn virtual void Print()
        *  \brief A virtual void function.
        *  \details It is used to print information of Product. 
        *  \return void
       */
        public virtual void Print()
        {
            Console.Write("| " + getId() + " | " + getName() + " | " + getPrice());

        }

        /*! \fn void Attach(Observer observer)
        *  \brief A void Attach function.
        *  \details It is used to add observer.
        *  \param observer an Observer object.
        *  \return void
        */
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        /*! \fn void Detach(Observer observer)
          *  \brief A void Detach function.
          *  \details It is used to remove observer.
          *  \param observer an Observer object.
          *  \return void
          */
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        /*! \fn void Notify()
          *  \brief A void Notify function.
          *  \details It is used to notify observer.
          *  \return void
        */
        private void Notify()
        {
            // Herhangi bir değişiklik olduğunda gözlemleyicilerimizin Update metotunu tetikleterek istenilen aksiyonu gerçekleştirebiliriz. Örneğin: Kullanıcılara e-posta atmak gibi düşünebilirsiniz.
            Console.WriteLine(observers.Count);
            observers.ForEach(o => { o.Update(); });
            
        }

        /*! \fn void ChangeStock()
          *  \brief A void changeStock function.
          *  \details It is used to notify observer if change is occurs in stock.
          *  \return void
        */
        public void ChangeStock()
        {
           // ... stok değiştirilme işlemleri
            // Stok değiştirildiğinde gözlemcilerimize bildiriyoruz.
            this.Notify();
        }
    }
}
