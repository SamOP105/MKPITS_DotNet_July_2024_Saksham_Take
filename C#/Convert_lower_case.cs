using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_lowercase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            char[] result = new char[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'A' && s[i] <= 'Z')
                {
                    result[i] = (char)(s[i] + 32);
                }
                else
                {
                    result[i] = s[i];
                }
            }

            Console.WriteLine("Lowercase string: " + new string(result));
            Console.Read();
        }
    }
}
