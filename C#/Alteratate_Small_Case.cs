
using System;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "APPLE";
            for (int iterate = 0; iterate < s.Length; iterate++)
            {
                // Check if the index is even
                if (iterate % 2 == 0)
                {
                    // Print the character in uppercase
                    Console.Write(char.ToUpper(s[iterate]));
                }
                else
                {
                    // Print the character in lowercase
                    Console.Write(char.ToLower(s[iterate]));
                }
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}

