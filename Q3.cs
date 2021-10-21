using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q3
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Numbers are:");

            for (int i = a + 1; i < b; i++)
            {
                Console.Write(i + "\t");
            }
        }
    }
}
