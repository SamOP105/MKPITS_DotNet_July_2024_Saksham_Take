using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Check_if_the_character_is_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char charToCheck = 'e';
            bool found = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == charToCheck)
                {
                    found = true;
                    break;
                }
            }
            Console.WriteLine(found ? "Character found" : "Character not found");
            Console.ReadLine();

        }
    }
}
