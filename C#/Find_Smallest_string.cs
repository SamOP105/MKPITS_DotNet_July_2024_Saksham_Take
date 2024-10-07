using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40_Find_the_Smallest_Word_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            string smallestWord = input;
            string currentWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    currentWord += input[i];
                }
                else
                {
                    if (currentWord.Length > 0 && currentWord.Length < smallestWord.Length)
                    {
                        smallestWord = currentWord;
                    }
                    currentWord = "";
                }
            }
            if (currentWord.Length > 0 && currentWord.Length < smallestWord.Length)
            {
                smallestWord = currentWord;
            }
            Console.WriteLine(smallestWord);
            Console.ReadLine();

        }
    }
}
