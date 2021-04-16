using Polymorphism.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee(); Console.WriteLine("Please type employee first name...");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Please type employee last name...");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Please type employee age...");
            employee.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type employee weight...");
            employee.Weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type employee height...");
            employee.Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type employee salary...");
            employee.Salary = decimal.Parse(Console.ReadLine());

            Console.WriteLine("*********Employee Information**********");
            Console.WriteLine($"First Name:{employee.FirstName}\nLast Name:{employee.LastName}\nAge:{employee.Age}\nWeight:{employee.Weight}\nHeight:{employee.Height}\nSalary:{employee.Salary}");
            Console.ReadLine();



            Customer customer = new Customer(); 
            Console.WriteLine("Please type customer first name...");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("Please type customer last name...");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("Please type customer age...");
            customer.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please type customer weight...");
            customer.Weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type customer height...");
            customer.Height = float.Parse(Console.ReadLine());
            Console.WriteLine("Please type customer credit card number...");
            customer.CreditCardNumber = Console.ReadLine();
            Console.WriteLine("Please type customer company name...");
            customer.CompanyName = Console.ReadLine();

            Console.WriteLine("*********Customer Information**********");
            Console.WriteLine($"First Name:{customer.FirstName}\nLast Name:{customer.LastName}\nAge:{customer.Age}\nWeight:{customer.Weight}\nHeight:{customer.Height}\nSalary:{customer.CreditCardNumber}\nCompany Name:{customer.CompanyName}");
            Console.ReadLine();


        }
    }
}
