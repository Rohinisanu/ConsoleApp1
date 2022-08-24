using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Book
    {
        string bookname;
        int price;
        string authorname;
        public string Bookname
        {
            set { bookname = value; }
            get { return bookname; }
        }
        public int Price
        {
            set { price = value; }
            get { return price; }

        }
        public string Authorname
        {
            set { authorname = value; }
            get { return authorname; }
        }

        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Bookname = "Chatrapati Shivaji Maharaj";
            b1.Price = 450;
            b1.Authorname = "Girish Jakhodiya";
            Console.WriteLine(b1.Bookname);
            Console.WriteLine(b1.Price);
            Console.WriteLine(b1.Authorname);

        }
    }
}
