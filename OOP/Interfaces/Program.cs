using Interfaces.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Please type book name...");
            book.BookName = Console.ReadLine();
            Console.WriteLine("Please type book author...");
            book.BookAuthor = Console.ReadLine();
            Console.WriteLine("Please type book genre...");
            book.BookGenre = Console.ReadLine();
            Console.WriteLine("Please type book description...");
            book.BookDescription = Console.ReadLine();
            Console.WriteLine("Please type book first publish date...");
            book.BookFirstPublishDate = Console.ReadLine();
            Console.WriteLine("Please type book page...");
            book.BookPage = int.Parse(Console.ReadLine());

            Console.WriteLine("****************");

            Console.WriteLine($"Book Name:{book.BookName}\nBook Author:{book.BookAuthor}\nBook Genre:{book.BookGenre}\nBook Description:{book.BookDescription}\nBook First Publish Date:{book.BookFirstPublishDate}\nBook Page:{book.BookPage}");
            Console.ReadLine();

        }
    }
}
