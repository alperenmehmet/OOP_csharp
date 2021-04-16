using Inheritance.ParentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ChildClass
{
    public class Iphone : BasePhone // Our Iphone.cs class will be inherited from BasePhone.cs class.
    {
        public string OperatingSystem;

        public override string PhoneRingSound() //override the PhoneRingSound() method.
        {
            return "Iphone tune...";
        }
    }
}
