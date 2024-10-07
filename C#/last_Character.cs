using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace last_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char lastChar = input[input.Length - 1];
            Console.WriteLine(lastChar);
            Console.ReadLine();

        }
    }
}
