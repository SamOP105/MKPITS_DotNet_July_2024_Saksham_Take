using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_special_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello@World#2024!";
            int specialCharCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // Check if character is not a letter and not a digit
                if ((input[i] < '0' || input[i] > '9') &&
                    (input[i] < 'A' || input[i] > 'Z') &&
                    (input[i] < 'a' || input[i] > 'z') &&
                    input[i] != ' ')
                {
                    specialCharCount++;
                }
            }

            Console.WriteLine(specialCharCount);
            Console.Read();
        }
    }
}
