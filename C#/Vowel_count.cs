using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_count
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter a string:");
                string input = Console.ReadLine();

                int vowelCount = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                        ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                    {
                        vowelCount++;
                    }
                }

                Console.WriteLine("Number of vowels: " + vowelCount);
            Console.Read();
            
        }

    }
}

