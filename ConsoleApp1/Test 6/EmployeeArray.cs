using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_6
{
    class EmployeeArray
    {
        int empid;
        string ename;
        int mgrid;
        public EmployeeArray()
        {

        }
        public EmployeeArray(int empid,string ename,int mgrid)
        {
            this.empid = empid;
            this.ename = ename;
            this.mgrid = mgrid;
        }
        public int Empid
        {
            set { empid = value; }
            get { return empid; }

        }
        public string Ename
        {
            set { ename = value; }
            get { return ename; }

        }
        public int Mgrid
        {
            set { mgrid = value; }
            get { return mgrid; }
        }

    }
    class Mtest
    {
        static void Main(string[] args)
        {
            EmployeeArray[] a = new EmployeeArray[5];
            a[0] = new EmployeeArray(1, "Pranav",1);
            a[1] = new EmployeeArray(2, "Medha", 1);
            a[2] = new EmployeeArray(3, "Deepa", 2);
            a[3] = new EmployeeArray(4, "Swati", 2);
            a[4] = new EmployeeArray(5, "Kirti", 3);
             foreach(EmployeeArray E in  a)
            {
                 foreach(EmployeeArray m in a)
                {
                    if(E.Mgrid==m.Empid)
                    {
                        Console.WriteLine($"EmpName:{ E.Ename}; ManagerName: { m.Ename}");
                    }
                }
            }
        }
    }
}
