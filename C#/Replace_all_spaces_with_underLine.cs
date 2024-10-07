using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_replace_all_spaces_with_underline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    result += '_';
                }
                else
                {
                    result += input[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
