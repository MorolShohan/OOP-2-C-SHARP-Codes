using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Book
{
    internal class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;
        private static int bookCounter = 0;

        public Book()
        {
            bookName = "";
            bookAuthor = "";
            bookId = "";
            bookType = "";
            bookCopy = 0;
            bookCounter++;
        }

        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
            bookCounter++;
        }

        public string BookName
        {
            set
            {
                this.bookName = value;
            }
            get
            {
                return this.bookName;
            }
        }

        public string BookAuthor
        {
            set
            {
                this.bookAuthor = value;
            }
            get
            {
                return this.bookAuthor;
            }
        }

        public string BookID
        {
            set
            {
                this.bookId = value;
            }
            get
            {
                return this.bookId;
            }
        }

        public string BookType
        {
            set
            {
                this.bookType = value;
            }
            get
            {
                return this.bookType;
            }
        }

        public int BookCopy
        {
            set
            {
                this.bookCopy = value;
            }
            get
            {
                return this.bookCopy;
            }
        }

        public void AddBookCopy(int x)
        {
            this.bookCopy += x;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Book Name : {0}\nAuthor : {1}\nID : {2}\nType : {3}\nNumber of Copies : {4}\n", this.bookName, this.bookAuthor, this.bookId, this.bookType, this.bookCopy);
        }

        public static void showTotalBookInfo()
        {
            Console.WriteLine("Number of Books in the Library : {0}", bookCounter);
        }


    }
}
   