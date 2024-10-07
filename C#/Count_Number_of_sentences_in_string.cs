using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_Count_the_Number_of_Sentences_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();
            int sentenceCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.' || input[i] == '!' || input[i] == '?')
                {
                    sentenceCount++;
                }
            }
            Console.WriteLine(sentenceCount);
            Console.ReadLine();

        }
    }
}
