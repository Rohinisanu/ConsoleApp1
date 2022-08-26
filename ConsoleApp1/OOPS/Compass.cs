using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Compass
    {
        string compassbrand;
        int price;
        Pen p;
        public Compass()
            {

        }
        public string Compassbrand
        {
            set { compassbrand = value; }
            get { return compassbrand; }
        }
        public int Price
        {
            set { price = value;}
            get { return price; }
        }


        class Pen
        {
            string penbrand;
            int penprice;
            string inkcolor;
            public Pen()
            {

            }
            public Pen(string penbrand,int penprice,string inkcolor)
            {
                this.penbrand = penbrand;
                this.penprice = penprice;
                this.inkcolor= inkcolor;
            }

            public string Penbrand
            {
                set { penbrand = value; }
                get { return penbrand; }

            }
            public int Penprice
            {
                set { penprice = value; }
                get { return penprice; }

            }
            public string Inkcolor
            {
                set { inkcolor = value; }
                get { return inkcolor; }
            }

        }
            static void Main(string[] args)
            {
            Compass c1 = new Compass();
            c1.Compassbrand = "Camel";
            c1.Price = 250;
            Pen p1 = new Pen("Trimax", 45,"red");
            c1.p = p1;
            Console.WriteLine(c1.p.Penbrand);

            }
    }
}
