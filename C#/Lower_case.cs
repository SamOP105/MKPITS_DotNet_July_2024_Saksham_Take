using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Lower_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string lowerCase = "";

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c >= 'A' && c <= 'Z')
                {
                    lowerCase += (char)(c + 32);
                }
                else
                {
                    lowerCase += c;
                }
            }
            Console.WriteLine(lowerCase);
            Console.ReadLine();

        }
    }
}
