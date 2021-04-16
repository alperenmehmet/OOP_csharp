using Abstraction.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Entities.Concrete
{
    public class Car : BaseEntity
    {
        public override Guid Id //I marked the Id in BaseEntity as abstract. Abstract member has to be override in the subclasses. 
        { 
            get => Guid.NewGuid(); 
            set { }
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Price { get; set; }
    }
}
