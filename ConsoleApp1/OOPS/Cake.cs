using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    interface Cake
    {
        void bake();
    }
    class Strawberry:Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking strawberry cake");
        }

    }
    class Blackforest : Cake
    {
        public void bake()
        {
            Console.WriteLine("Baking Blackforse Cake");
        }
    }
    class Cake1
    {
        static void Main(string[] args)
        {
            Cake c = new Strawberry();
            c.bake();
            Cake c1 = new Blackforest();
            c1.bake();
            
        }
    }
    

    }

