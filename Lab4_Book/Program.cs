using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("Aronnok", "Bibhutibhushan Bandyopadhay", "245", "Novel", 90);
            b1.AddBookCopy(50);
            b1.ShowInfo();


            Book b2 = new Book();
            b2.BookName = "Megher Upor Bari";
            b2.BookAuthor = " Humayun Ahmed ";
            b2.BookID = "834";
            b2.BookType = "Novel";
            b2.BookCopy = 100;
            b2.AddBookCopy(50);
            b2.ShowInfo();
            Console.WriteLine();
            Book.showTotalBookInfo();
        }

    }
}
   