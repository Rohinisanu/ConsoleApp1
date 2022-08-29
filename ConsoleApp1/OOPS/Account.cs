using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.OOPS
{
    class Account
    {
        long accountnumber;
         string customername;
        int balance;
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
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public void Withdraw(int wamt)
        {
            if (balance < wamt)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance = balance - wamt;
                Console.WriteLine("Withdraw successfully");
            }
        }
            public void Deposit(int damt)
            {
                balance = balance + damt;
                Console.WriteLine("Deposited Successfully");
            }
        public void CheckBalance()
        {
            Console.WriteLine("Current balance is="+balance);
        }
        
        static void Main(string[] args)
        {
            Account a1 = new Account();
            a1.Accountnumber = (10000000000000295);
            a1.Customername = ("Rohini Gite");
            a1.Balance = 20000;
            a1.CheckBalance();
            Console.WriteLine(a1.Accountnumber);
            Console.WriteLine(a1.Customername);
            Console.WriteLine(a1.Balance);
            
        }
  
    }
}
