using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class InheritanceP
    {
        int i;
        public InheritanceP()
        {
            Console.WriteLine("I am in InheritanceP");
        }
        public InheritanceP(int i)
        {
            this.i = i;
            Console.WriteLine("I am Parameterised");
        }
        public int I
        {
            set { i = value; }
            get { return i; }
        }
        class C : InheritanceP
        {
            int j;
            public C() : base(20)
            {
                Console.WriteLine("I am in C");
            }
            public C(int i, int j) : base(i)
            {
                this.j = j;

            }

        }
        class Test
        {
            static void Main(string[] args)
            {
                C ob = new C();
                C ob1 = new C(10, 20);

            }

        }

    }
}