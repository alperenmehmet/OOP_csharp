using Inheritance.ChildClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Iphone*****");
            Iphone iphone = new Iphone();

            iphone.Brand = "Apple";
            iphone.Model = "Iphone 12 Pro";
            iphone.UnitPrice = "$999";
            iphone.Color = "Silver";
            iphone.OperatingSystem = "IOS 14";

            Console.WriteLine($"Brand :{iphone.Brand}\nModel :{iphone.Model}\nUnit Price :{iphone.UnitPrice}\nColor :{iphone.Color}\nOperating System :{iphone.OperatingSystem}\nRing Sound:{iphone.PhoneRingSound()}");

            Console.WriteLine("\n*****Samsung*****");
            Samsung samsung = new Samsung();

            samsung.Brand = "Samsung";
            samsung.Model = "Galaxy S21 Ultra 5G";
            samsung.UnitPrice = "$499.99";
            samsung.Color = "Phantom Silver";
            samsung.OperatingSystem = "One UI 3.1, Android 11";

            Console.WriteLine($"Brand :{samsung.Brand}\nModel :{samsung.Model}\nUnit Price :{samsung.UnitPrice}\nColor :{samsung.Color}\nOperating System :{samsung.OperatingSystem}\nRing Sound:{samsung.PhoneRingSound()}");

            Console.WriteLine("\n*****Nokia*****");
            Nokia nokia = new Nokia();

            nokia.Brand = "Nokia";
            nokia.Model = "3310";
            nokia.UnitPrice = "Not available.";
            nokia.Color = "Silver";
            //nokia.OperatingSystem = "";   If you can go to Nokia.cs, you will see there is no OperatingSystem in Nokia.cs...
            Console.WriteLine($"Brand :{nokia.Brand}\nModel :{nokia.Model}\nUnit Price :{nokia.UnitPrice}\nColor :{nokia.Color}\nOperating System :{""}\nRing Sound:{nokia.PhoneRingSound()}");
            Console.ReadLine();

        }
    }
}
