using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Arrays
{
    class DataMerge
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 5, 4 };
            int[] b = {8, 5, 9, 87, 3};
            int[] c = new int[a.Length + b.Length];
         
         
            for (int i = 0; i < a.Length; i++)
            {
              
                c[i] = a[i];
            }
            for(int i=0;i<b.Length;i++)
            {
                c[a.Length + i] = b[i];

               
            }
            for(int i=0;i<c.Length;i++)
                Console.WriteLine(c[i]);
            

            
        }
        
        
    }
}
