
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Test_4
{
    class IMEInumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            long n = long.Parse(Console.ReadLine());
            int c = 0;
            long copy = n;
            while(n>0)
                {
                c++;
                n = n / 10;
                if(c!=15)
                    Console.WriteLine("Invalid IMEI Number");
                else
                {
                    int sum = 0;
                    n = copy;
                    c = 0;
                    while(n>0)
                    {
                        int r = (int)(n % 10);
                        c++;
                        if(c%2==1)
                        {
                            int doubleup = 2 * r;
                                
                                sum = sum + doubleup % 10 + doubleup / 10;

                            }
                            else
                            {
                                sum = sum + r;
                            }
                        if(sum%10==0)
                            Console.WriteLine("Valid IMEI Number");
                        else
                            Console.WriteLine("Not Valid IMEI Number");

                        }

                    }
                }
            }
        }
    }

