using System;
using System.Collections.Generic;
using System.Text;

namespace Snippet_2
{
    class Book
    {
        string bookName;
        long bookID;
        public Book(string name, int value)
        {
            bookName = name;
            bookID = value;
        }
        public string BookName
        {
            get
            {
                return bookName;
            }
        }
        public long BookID
        {
            get
            {
                return bookID;
            }
        }
    }
}
