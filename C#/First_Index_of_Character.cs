using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Find_the_Index_of_a_Character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();
            char charToFind = 'o';
            int index = -1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == charToFind)
                {
                    index = i;
                    break;
                }
            }
            Console.WriteLine(index);
            Console.ReadLine();

        }
    }
}
