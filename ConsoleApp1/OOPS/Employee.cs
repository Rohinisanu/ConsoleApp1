using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Employee
    {
        int id;
        string name;
        int salary;
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Id = (3002);
            e1.Name = ("Dattatraya");
            e1.Salary = (60000);
            Console.WriteLine(e1.Id);
            Console.WriteLine(e1.Name);
            Console.WriteLine(e1.Salary);

        }

    }
}
