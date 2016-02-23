using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsAndUnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();

            // try setting year below year 1100
            try
            {
                b.SetYear(200);
                Console.WriteLine("The book was written in {0}", b.GetYear());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid year: The database only holds records for books written between 1100 and 2015");
            }

            // Try setting title with less than 2 characters
            try
            {
                b.SetTitle("a");
                Console.WriteLine("The title of the book is {0}", b.GetTitle());
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid title: Title must be at least two characters long");
            }


            Console.ReadKey();
        }
    }
}
