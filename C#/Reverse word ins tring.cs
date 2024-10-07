using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38_Reverse_the_Words_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            string result = "";
            string word = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] != ' ')
                {
                    word = input[i] + word;
                }
                else
                {
                    result += word + ' ';
                    word = "";
                }
            }
            result += word; 
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
