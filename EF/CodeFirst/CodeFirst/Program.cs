using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        static BooksContext context = new BooksContext();
        static void Main(string[] args)
        {
            AddBook();
            ShowBooks();
            Console.Read();
        }

        static void ShowBooks()
        {
            var bk = from b in context.book
                     select b;

            foreach (var c in bk)
            {
                Console.WriteLine(c.BookId + " " + c.BookName + " " + c.Price+ " " + c.YearPublished + " " + c.Rating);
            }
        }

        static void AddBook()
        {
            Books books = new Books();
            Console.WriteLine("Enter Details Id, Name, Price, Yr Published , Rating:");

            books.BookId = Convert.ToInt32(Console.ReadLine());
            books.BookName = Console.ReadLine();
            books.Price = Convert.ToDouble(Console.ReadLine());
            books.YearPublished = Convert.ToDateTime(Console.ReadLine());
            books.Rating = Convert.ToInt32(Console.ReadLine());
            context.book.Add(books);
            context.SaveChanges();
        }
    }
}
