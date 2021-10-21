using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q5
    {
        static void Main(string[] args)
        {
            int countEven = 0;
            int countOdd = 0;

            Console.WriteLine("enter array:");
            int[] a = new int[10];

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int i in a)
            {
                if (i % 2 == 0)
                {
                    countEven += 1;
                }
                else
                {
                    countOdd += 1;
                }
            }
            Console.WriteLine("No. of Even Inputs are:\t" + countEven + " and no. of Odd inputs are:" + countOdd);
        }
    }
}
