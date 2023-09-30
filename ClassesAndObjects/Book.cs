using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string Aname,string Aauthor, int Apage)
        {
            title = Aname;
            author = Aauthor;
            pages = Apage;

        }
    }
}
