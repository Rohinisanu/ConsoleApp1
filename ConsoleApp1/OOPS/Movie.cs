using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Movie
    {
         string moviename;
        string actorname;
        float rating;
        int releaseyear;
        public string Moviename
        {
            set { moviename = value; }
            get { return moviename; }
        }
        public string Actorname
        {
            set { actorname = value; }
            get { return actorname; }
        }
        public float Rating
        {
            set { rating = value; }
            get { return rating; }
        }
        public  int Releaseyear
        {
            set { releaseyear = value; }
            get { return releaseyear; }
        }
       
        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            m1.Moviename = ("Dharmaveer");
            m1.Actorname = ("Prasad Oak");
            m1.Rating = (4);
            m1.Releaseyear = (2022);
            Console.WriteLine(m1.Moviename);
            Console.WriteLine(m1.Actorname);
            Console.WriteLine(m1.Rating);
            Console.WriteLine(m1.Releaseyear);
            
        }
    }
}
