using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Find_and_display_the_Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number for its multiplication table: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMultiplication Table of "+number);

            for (int i = 1; i <= 10; i++)
            {
                int result = number * i;
                Console.WriteLine(number+" x " +i +" = "+ result);
            }
        }
    }
}
