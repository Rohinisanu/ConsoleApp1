using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Account
    {
        long accountnumber;
         string customername;
        public long Accountnumber
        {
            set { accountnumber = value; }
            get { return accountnumber; }
        }
        public string Customername
        {
            set { customername = value; }
            get { return customername; }
        }
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.Accountnumber = (10000000000000295);
            a1.Customername = ("Rohini Gite");
            Console.WriteLine(a1.Accountnumber);
            Console.WriteLine(a1.Customername);
        }
  
    }
}
