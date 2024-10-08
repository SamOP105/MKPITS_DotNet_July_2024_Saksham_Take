using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Check_if_a_number_is_divisible_by_both_3_and_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 3 == 0 && num % 5 == 0)
            {
                Console.WriteLine("Divisible by both 3 and 5");
            }
            else
            {
                Console.WriteLine("Not divisible by both 3 and 5");
            }
            Console.Read();
        }
    }
}
