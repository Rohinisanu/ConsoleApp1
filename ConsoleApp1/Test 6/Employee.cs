using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class Employee
    {
        string name;
        int eid;
        int mgrid;
        string managername;
        public Employee()
        {

        }
        public Employee(string name, int eid, int mgrid,string managername)
        {
            this.name = name;
            this.eid = eid;
            this.mgrid = mgrid;
            this.managername = managername;
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Eid
        {
            set { eid = value; }
            get { return eid; }
        }
        public int Mgrid
        {
            set { mgrid = value; }
            get { return mgrid; }
        }
        public string Managername
        {
            set { managername = value; }
            get { return managername; }
        }
        public override string ToString()
        {
            return "Name:" + name + "Eid:" + eid + "Mgrid:" + mgrid + "Managername:" + managername;

        }
        static void Main(string[] args)
        {
            Employee[] a = new Employee[5];
            a[1] = new Employee("Rohini", 01, 100,"Gite");
            a[2] = new Employee("Rohini", 01, 100,"Gite");
            a[3] = new Employee("Rohini", 01, 100,"Gite");
            a[4]=  new Employee("Rohini", 01, 100,"Gite");
            a[5] = new Employee("Rohini", 01, 100,"Gite");
            Console.WriteLine(a[5]);
        }
    }
}
