using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q4
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("Input is Even");
            }
            else
            {
                Console.WriteLine("Input is Odd");
            }
        }
    }
}
