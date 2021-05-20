using System;

namespace Assignment22Oct
{
    class Book
    {
        string BookName;
        string AuthorName;
        public Book(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }
        public void Display()
        {
            Console.WriteLine($"Book name :{BookName} , Author Name:{AuthorName}");
        }
    }
    class BookShelf
    {
        Book[] book = new Book[5];

        public Book this[int x]
        {
            get
            {
                return book[x];
            }
            set
            {
                book[x] = value;
            }
        }

    }
    class Question1
    {
        static void Main()
        {
            BookShelf BS = new BookShelf();
            BS[0] = new Book("Cricket World Cup: The Indian Challenge", "Ashis Ray");
            BS[1] = new Book("My Journey", "Dr. A.P.J. Abdul Kalam");
            BS[2] = new Book("Making of New India", "Dr. Bibek Debroy");
            BS[3] = new Book("Darkness to light", "Lamar Odom");
            BS[4] = new Book("‘Virat: The making of a Champion’", "Neeraj Jha, Vidhanshu Kumar");
            for(int i=0; i<5; i++)
            {
                BS[i].Display();
            }
            Console.ReadLine();
        }
    }
}
