namespace ConsoleApp1.Arrays
{
    class MaxMinValue
    {
        static void Main(string[] args)
        {

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
                if(min>a[i])
                {
                    min = a[i];
                }
               
            }
            System.Console.WriteLine("Max value="+max);
            System.Console.WriteLine("Min value="+min);
           
        }
    }
}
