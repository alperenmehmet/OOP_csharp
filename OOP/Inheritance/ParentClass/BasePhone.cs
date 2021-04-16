using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ParentClass
{
    public class BasePhone
    {
        public string Brand;
        public string Model;
        public string UnitPrice;
        public string Color;
        //Sometimes we want to give different feature to child class. As you can see below, I write a method. Because every phone has different phone ring. In the ChildClass, I will override this method and gain some new feature in the ChildClasses.
        public virtual string PhoneRingSound()
        {
            return "Phone is ringing";
        }
    }
}
