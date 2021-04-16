using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.Model = "MacBook Pro";
            computer.Capacity = "512 GB";
            computer.Display = "13.3-inch Retina Display";
            
            Phone phone = new Phone();
            phone.Brand = "Apple";

            Console.WriteLine($"Computer Model:{computer.Model}\nComputer Capacity:{computer.Capacity}\nComputer Display:{computer.Display} ");
            Console.WriteLine($"Phone Brand:{phone.Brand}");

            Console.ReadLine();

        }

        public class Computer
        {
            private string Brand; //Access modifier is private so we can't access it.
            public string Model; //Access modifier is public so we can access it eveywhere.
            protected string Color; //Access modifier is protected so we can't access it.
            internal string Capacity; //Access modifier is internal so we can access it in the same assembly.
            internal protected string Display; //Access modifier is internal protected so we can access it in the same assembly.
            private protected double Price; //Access modifier is private protected so we can't access it.
        }

        private class Phone
        {
            public string Brand; //Access modifier is public so we can access it eveywhere.
            private string Model;   //This property is signed as private so we can't access this property outside of class.
            private string Color;   //This property is signed as private so we can't access this property outside of class.
            private string Capacity;//This property is signed as private so we can't access this property outside of class.
            private string Display; //This property is signed as private so we can't access this property outside of class.
            private double Price;   //This property is signed as private so we can't access this property outside of class.
        }
    }
}
