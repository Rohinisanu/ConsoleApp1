using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test5
{
    class Car
    {
        string name;
        int price;
        public Car()
        {

        }
        public Car(string name,int price)
        {
            this.name = name;
            this.price = price;
           

        }
        public Car(int price,string name)
        {
            this.price = price;
            this.name = name;
        }
        public void show()
        {
            Console.WriteLine("Carname=" +name);
            Console.WriteLine("Carprice=" +price);
        }
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car("Hondacity", 5000000);
            Car c3 = new Car(6000000, "Swift Desire");
            Console.WriteLine("Second Constructor");
            c2.show();
            Console.WriteLine("Third Constructor");
            c3.show();
        }
    }
}
