using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Printing the Series of squares from 1 to 25:");
            for (int i = 1; i < 26; i++)
            {
                int square = i * i;
                Console.Write(square + "\t");
            }
        }
    }
}
