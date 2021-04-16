using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }

        private decimal _unitPrice;
        public decimal UnitPrice
        {
            get { return _unitPrice; }
            set
            {
                if (value>0)
                {
                    _unitPrice = value;
                }

                else
                {
                    Console.WriteLine("Unit price must be greater than zero!!!");
                }
            }
        }

        private int _unitsInStock;
        public int UnitsInStock
        {
            get { return _unitsInStock; }
            set
            {
                if (value>0)
                {
                    _unitsInStock = value;
                }

                else
                {
                    Console.WriteLine("Units In Stock must be greater than zero!!!");
                }
            }
        }
    }
}
