using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_7
{
    class EmployeeD
    {
        int id;
        string name;
        Dept d;
     
        public EmployeeD()
        {

        }
        public EmployeeD(int id, string name, Dept d)
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
            Console.WriteLine("Enter dept id");
            int depid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter dept name");
            string dname = Console.ReadLine();
            Dept d = new Dept(depid, dname);
            EmployeeD[] emp = new EmployeeD[3];
            for (int i = 0; i < emp.Length; i++)
            {
                Console.WriteLine("Enter the employee id");
                int empid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter employee name");
                string emname = Console.ReadLine();
                emp[i] = new EmployeeD(empid, emname, d);
            } 
            foreach(EmployeeD elements in emp)
            {
                Console.WriteLine(elements);
            }
          
            
        }
    }
}

        