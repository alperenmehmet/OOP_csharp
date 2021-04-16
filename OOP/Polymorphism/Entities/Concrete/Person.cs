using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Entities.Concrete
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int _age;
        public virtual int Age
        {
            get => _age;
            set
            {
                if (value<1)
                {
                    throw new Exception("Age nust be greater than one!!!");
                }
                else
                {
                    _age = value;
                }
            }
        }
        public float _weight;
        public virtual float Weight 
        {
            get => _weight;
            set
            {
                if (value<1f)
                {
                    throw new Exception("Weight must be greater than one!!!");
                }
                else
                {
                    _weight = value;
                }
            }
        }
        public float _height;
        public virtual float Height 
        { 
            get =>_height;
            set
            {
                if (value<0.3f || value>3f)
                {
                    throw new Exception("Height must be greater than 0.3 and be lower than 3!!!");
                }
                else
                {
                    _height = value;
                }
            }
        }
    }
    
}
