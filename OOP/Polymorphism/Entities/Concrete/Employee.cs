using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Entities.Concrete
{
    public class Employee:Person
    {
        public decimal Salary { get; set; }
        public override int Age 
        { 
            get =>_age;
            set
            {
                if (value<18)
                {
                    throw new Exception("Employee age must be greater than 18!!!");
                }
                else
                {
                    _age = value;
                }
            }
        }
    }
}
