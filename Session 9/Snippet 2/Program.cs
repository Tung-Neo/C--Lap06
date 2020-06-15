using System;

namespace Snippet_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book objBook = new Book("Learn C# in 21 Days", 10015);
            Console.WriteLine("Book Name: " + objBook.BookName);
            Console.WriteLine("Book ID: " + objBook.BookID);
        }
    }
}
