using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q6
    {
        static void Main(string[] args)
        {
            double cel;
            Console.WriteLine("Enter temperature in Fahreinheit:");
            double fah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Fahrenheit: " + fah);
            cel = (fah - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + cel);
        }
    }
}
