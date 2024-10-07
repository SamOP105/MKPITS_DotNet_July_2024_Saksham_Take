using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Replace_Characters_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            char charToReplace = 'o';
            char replacementChar = 'a';
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == charToReplace)
                {
                    result += replacementChar;
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
