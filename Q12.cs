using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q12
    {
        static void Main(string[] args)
        {
            int k = 0;
            Console.WriteLine("Input three numbers");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                k = a;

            }
            else if (b > c)
            {
                k = b;
            }
            else
            { 
                k = c;
            }

            Console.WriteLine($"Largest among {a},{b} and {c} is {k} ");
        }
    }
}
