using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I got a degree");
        }
    }
        class Undergraduate
        {
            public void getDegree()
            {
                Console.WriteLine("I am an Undergraduate");
            }
            
        }
        class Postgraduate
        {
            public void getDegree()
            {
                Console.WriteLine("I am Postgraduate");
            }
        }
        
         

    
    class Test
    {
        static void Main(string[] args)
        {
            Degree d1 = new Degree();
            d1.getDegree();
            Undergraduate u = new Undergraduate();
            u.getDegree();
            Postgraduate p = new Postgraduate();
            p.getDegree();

        }
        

    }
}
