using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class CMP
    {
        string compassbrand;
        int price;
        Pen p;
        public CMP()
        {

        }
        public virtual string Compassbrand
        {
            set { compassbrand = value; }
            get { return compassbrand; }
        }
        public virtual int Price
        {
            set { price = value; }
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
            public Pen(string penbrand, int penprice, string inkcolor)
            {
                this.penbrand = penbrand;
                this.penprice = penprice;
                this.inkcolor = inkcolor;
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
        public override string ToString()
        {
            return "Cmpbrand:" + Compassbrand + "Cprice:" + Price;
        }
        static void Main(string[] args)
        {
            CMP c1 = new CMP();
            c1.Compassbrand = "Camel";
            c1.Price = 250;
            Pen p1 = new Pen("Trimax", 45, "red");
            c1.p = p1;
            Console.WriteLine(c1.Compassbrand);
            Console.WriteLine(c1.p);
        }
    }
}


    

