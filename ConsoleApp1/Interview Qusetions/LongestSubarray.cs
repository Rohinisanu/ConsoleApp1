using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Interview_Qusetions
{
    class LongestSubarray
    {
        public static int LongSubArr(int[]a)
        {
           
            int max = int.MinValue;
            for(int i=0;i<a.Length;i++)
            {
                int zero = 0, one = 0;
                for(int j=i;j<a.Length;j++)
                {
                    if (a[j] == 0)
                        zero++;
                    else if (a[j] == 1)
                        one++;
                    if(zero==one)
                    {
                        if (max < j - i + 1)
                            max = j - i + 1;
                    }

                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] a = { 1, 0, 1, 1, 0, 0, 1, 0, 0, 1, 1, 0, 1, 0 };
           
            int max = LongSubArr(a);
                Console.WriteLine("Max="+max);
        }

        }
    }

