using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_Capitalize_the_First_Letter_of_Each_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            bool capitalizeNext = true;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    result += ' ';
                    capitalizeNext = true;
                }
                else
                {
                    if (capitalizeNext)
                    {
                        result += char.ToUpper(input[i]);
                        capitalizeNext = false;
                    }
                    else
                    {
                        result += input[i];
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
