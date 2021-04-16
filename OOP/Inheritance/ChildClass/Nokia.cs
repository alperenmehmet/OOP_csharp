using Inheritance.ParentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.ChildClass
{
    public class Nokia : BasePhone //we add the parent class.
    {
        public override string PhoneRingSound()
        {
            return "Nokia tune...";
        }
    }
}
