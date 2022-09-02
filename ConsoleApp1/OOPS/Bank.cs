using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Bank
    {
        string bankname;
        string branch; string address;
        string ifsc;
       public void accept()
        {
            Console.WriteLine("In accept");
        }
    }
    class HDFC : Bank
    {
        float roi;
    }

    class Test
{
    static void Main(string[] args)
    {
        HDFC h = new HDFC();
        h.accept();
    }
}
}
