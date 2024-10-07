using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_occrence_of_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();

            Console.WriteLine("Enter the character to count:");
            char charToCount = Console.ReadLine()[0];
            int count = 0;

            foreach (char c in input)
            {
                if (c == charToCount)
                {
                    count++;
                }
            }

            Console.WriteLine("Character '" + charToCount + "' appears " + count + " times.");
        }
    }
}
