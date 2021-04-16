using Abstraction.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "Ford";
            car.Model = "Ford Ranger Raptor";
            car.Engine = "2.0L EcoBlue 213 PS(157kW)";
            car.Transmission = "10-speed automatic";
            car.Price = "$42,000";

            Console.WriteLine($"Id:{car.Id}\nBrand:{car.Brand}\nModel:{car.Model}\nEngine:{car.Engine}\nTransmission:{car.Transmission}\nPrice:{car.Price}\nStatus:{car.Status}\nCreate Date:{car.CreateDate}");
            Console.ReadLine();
        }
    }
}
