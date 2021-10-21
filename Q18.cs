using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Q18
    {
        static void Main(string[] args)
        {
            string rev = null;
            Console.WriteLine("Enter the word");
            string word = Console.ReadLine();
            word = word.ToLower();
            for (int i = word.Length - 1; i >= 0; i--)
            {
                rev += word[i];
            }

            if (word == rev)
            {
                Console.WriteLine($"{word} is a palindrome");
            }
            else
                Console.WriteLine($"{word} is not a palindrome");
        }
    }
}
