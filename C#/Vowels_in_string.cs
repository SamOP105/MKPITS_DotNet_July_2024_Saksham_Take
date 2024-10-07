using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_vowels_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            int vowelCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char c = char.ToLower(input[i]);
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
            }
            Console.WriteLine("Vowel: "+vowelCount);
            Console.Read();
        }
    }
}
