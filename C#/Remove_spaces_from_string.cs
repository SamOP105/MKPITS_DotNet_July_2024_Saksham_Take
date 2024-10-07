using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_remove_spaces_from_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
