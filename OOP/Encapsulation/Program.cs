using Encapsulation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            Console.WriteLine("Please type product name.");
            product.Name = Console.ReadLine();
            Console.WriteLine("Please type unit price.");
            product.UnitPrice = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please type units in stock.");
            product.UnitsInStock = int.Parse(Console.ReadLine());

            if (product.UnitPrice>0 && product.UnitsInStock>0)
            {
                Console.WriteLine($"Product ID:{product.Id}\nProduct Name:{product.Name}\nProduct Unit Price:{product.UnitPrice}\nProduct Units In Stock:{product.UnitsInStock}\nCreate Date:{product.CreateDate}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Something goes wrong...Please try again...");
                Console.ReadLine();
            }
        }
    }
}
