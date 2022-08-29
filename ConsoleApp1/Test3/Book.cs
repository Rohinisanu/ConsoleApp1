using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test3
{
    class Book
    {
        string title;
        string author;
        double price;

        public string Title
        {
            set { title = value; }
            get { return title; }
        }
        public string Author
        {
            set { author = value; }
            get { return author; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        public Book(String title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;

        }
    
        class BookDemo
        {
            static void Main(string[] args)
            {
                Book b = new Book();
                b.Title = "Developing Java Software";
                b.Author = "Russel Winderand";
                b.Price = 79.75;
                Console.WriteLine(b.Title,b.Author,b.Price);
            }
        }


    }
}
