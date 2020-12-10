using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "Beginners to coding";
            myBook.Author = "Connor Hagerman";
            myBook.Year = 2000;
            Console.WriteLine("{0} {1} {2}", myBook.Title, myBook.Author, myBook.Year);
            Console.ReadLine();


            Book myBookTest;
            myBookTest = myBook;

            Console.WriteLine("{0} {1} {2}", myBook.Title, myBook.Author, myBook.Year);
            Console.ReadLine();

            myBookTest.Year = 2000;
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }               


        public Book()
        {
            Title = "Beginner to coding"; 
        }
    }    
}
