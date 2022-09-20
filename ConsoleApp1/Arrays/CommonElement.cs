using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class CommonElement
    {
        static bool isAlreadyPresent(int[]a,int current)
        {
        
            for(int i=0;i<current;i++)
            {
                if (a[i] == a[current])
                    return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 1, 2, 1 };
            int[] b = { 7, 8, 9, 10, 3, 5, 4, 1,4};
            for(int i=0;i<a.Length;i++)
            {
                if (isAlreadyPresent(a, i) == false)
                { 
                    int c = 0;
                        for (int j = 0; j < b.Length; j++)
                        {

                            if (a[i] == b[j])
                                c++;
                            
                         }
                               
                  
                            if(c>0)
                                Console.WriteLine(a[i]);

                }

                
            }
        }
    }
}
