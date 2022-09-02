using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Pen
    {
        int caplength;
        string brand;
        Refill r;
        public Pen()
        {

        }
        public Pen(int caplength, string brand, Refill r)
        {
            this.caplength = caplength;
            this.brand = brand;
            this.R = r;
        }
        public int Caplength
        {
            set { caplength = value; }
            get { return caplength; }
        }
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        public Refill R
        {
            set { r = value; }
            get { return r; }
        }
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib tip;
        public Refill()
        {

        }
        public Refill(string inkcolor, int length, Nib tip)
        {
            this.inkcolor = inkcolor;
            this.length = length;
            this.tip = tip;
        }
        public string Inkcolor
        {
            set { inkcolor = value; }
            get { return inkcolor; }
        }
        public int Length
        {
            set { length = value; }
            get { return length; }
        }
        public Nib Tip
        {
            set { tip = value; }
            get { return tip; }
        }
    }
    class Nib
    {
        string materialtype;
        int width;
        public Nib()
        {

        }
        public Nib(string materialtype, int width)
        {
            this.materialtype = materialtype;
            this.width = width;
        }
        public string Materialtype
        {
            set { materialtype = value; }
            get { return materialtype; }
        }
        public int Width
        {
            set { width = value; }
            get { return width; }
        }

       
        
            static void Main(string[] args)
            {
                Pen p = new Pen(6, "cello", new Refill("blue", 2, new Nib("plastic", 4)));
                Console.WriteLine(p.Brand);
                Console.WriteLine(p.R.Inkcolor);
                Console.WriteLine(p.R.Tip.materialtype);
            }


        }

    }

