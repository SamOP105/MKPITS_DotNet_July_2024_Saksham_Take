using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39_Find_Longest_Word_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string longest = "";
            string current = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    current += input[i];
                }
                else
                {
                    if (current.Length > longest.Length)
                    {
                        longest = current;
                    }
                    current= "";
                }
            }
            if (current.Length > longest.Length)
            {
                longest = current;
            }
            Console.WriteLine(longest);
            Console.ReadLine();

        }
    }
}
