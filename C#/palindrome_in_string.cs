using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();


            string reversedString = ""; //reverse a string
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }


            if (input == reversedString) //compare
            {
                Console.WriteLine("The string is a palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a palindrome.");
            }
            Console.Read();
        }
    }
}
