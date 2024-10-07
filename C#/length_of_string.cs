using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_length_of_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            int length = 0;

            foreach (char c in input)
            {
                length++;
            }

            Console.WriteLine("Length of the string: " + length);
            Console.Read();
        }
    }
}
