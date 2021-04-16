using Inheritance.ParentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ChildClass
{
    public class Samsung : BasePhone //we add the parent class.
    {
        public string OperatingSystem;
        public override string PhoneRingSound()
        {
            return "Samsung tune...";
        }
    }
}
