using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Student1
    {
        int age;
        string name;
        float percentage;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public float Percentage
        {
            set { percentage = value; }
            get { return percentage; }
        }
        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.Age = (22);
            s1.Name = ("Pranjal");
            s1.Percentage = (70.33f);
            Console.WriteLine(s1.Age);
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.Percentage);
        }
    }
}
