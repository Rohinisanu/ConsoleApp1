using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_4
{
    class Employee
    {
        int id;
        string name;
        Dept d;
        public Employee()
        {

        }
        public Employee(int id, string name, Dept d)
        {
            this.id = id;
            this.name = name;
            this.d = d;
        }
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
        public Dept D
        {
            set { d = value; }
            get { return d; }
        }
    }
    class Dept
    {
        int deptid;
        string dname;
        public Dept()
        {

        }
        public Dept(int deptid, string dname)
        {

            this.deptid = deptid;
            this.dname = dname;
        }
        public int Deptid
        {
            set { deptid = value; }
            get { return deptid; }
        }
        public string Dname
        {
            set { dname = value; }
            get { return dname; }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee(101,"Pranjal",(new Dept(02,"E&TC")));
            Console.WriteLine(e.Id);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.D.Deptid);
            Console.WriteLine(e.D.Dname);
        }

    }

    }

