using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.StringBuilderAsst
{
    class Functions1
    {
        static void Main(string[] args)
        {
            string s = "Om";
           
            StringBuilder sb = new StringBuilder("Sanvi");
            sb.Append("Aarav");
            sb.AppendLine("Rohini");
            sb.Append("sanu");
            Console.WriteLine(sb.Capacity);
            sb.Insert(2,"Sanu");
            sb.Remove(1, 4);
            sb.Replace('s', '*');
            Console.WriteLine(sb);
        


        }
    }
}
