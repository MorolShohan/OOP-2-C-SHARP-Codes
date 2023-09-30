using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter ","J.K Rowling", 400 );
          /*  book1.title = 
            book1.author = 
            book1.pages = */

            Book book12 = new Book("Lord of the rings ", "Shohan", 4500) ;
           /* book12.title = 
            book12.author =
            book12.pages = */

            /* Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine("+++");

            Console.Write(book12.title);
            Console.WriteLine(book12.author);
                Console.WriteLine(book12.pages); */
            Console.WriteLine(book1.title);
        }
    }
}
