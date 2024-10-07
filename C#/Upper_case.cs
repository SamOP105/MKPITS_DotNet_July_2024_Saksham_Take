using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Upper_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string upperCase = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'a' && c <= 'z')
                {
                    upperCase += (char)(c - 32);
                }
                else
                {
                    upperCase += c;
                }
            }
            Console.WriteLine(upperCase);
            Console.ReadLine();
        }
    }
}
