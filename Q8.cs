using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q8
    {
        static void Main(string[] args)
        {
            int mul = 1;
            Console.WriteLine("Enter the Number:");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                mul = mul * i;

            }

            Console.WriteLine("Factorial of the number is:" + mul);
        }
    }
}
