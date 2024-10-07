using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_count_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            int wordCount = 0;

            
            if (s.Length > 0 && s[0] != ' ')
            {
                wordCount++;
            }

        
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] != ' ' && s[i - 1] == ' ')
                {
                    wordCount++;
                }
            }

            Console.WriteLine("Number of words: " + wordCount);
            Console.Read();
        }
    }
}
