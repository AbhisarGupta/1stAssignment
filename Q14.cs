using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q14
    {
        static void Main(string[] args)
        {
            int total = 0, min = 0, max = 0, avg = 0;
            Console.WriteLine("Enter the marks ");
            
            int[] mark = new int[10];
            for (int i = 0; i < 10; i++)
            {
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                total = total + mark[i];
            }
            avg = total / 10;
            Array.Sort(mark);
            Console.WriteLine($"Total  marks  is {total}");
            Console.WriteLine($"Average  marks is {avg}");
            Console.WriteLine($"Minimum marks is is {mark[0]}");
            Console.WriteLine($"Maximum marks is is {mark[9]}");

            
            Console.WriteLine("Marks in Ascending order");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(mark[i]);
            }


            
            Console.WriteLine(" Marks in Descending order");
            Array.Reverse(mark);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(mark[i]);
            }

        }
    }
}
