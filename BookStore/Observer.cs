using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    /*! \class Observer
     *  \brief It is abstract Observer class.
     */
    public abstract class Observer

        {
            //Değişimde haber gider
            public abstract void Update();
        }
    
}
