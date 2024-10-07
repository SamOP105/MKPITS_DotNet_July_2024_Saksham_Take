using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Remove_Duplicates_from_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (result.IndexOf(input[i]) == -1 && input[i] != ' ')
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
