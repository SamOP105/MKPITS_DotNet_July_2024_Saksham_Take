using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Find_the_sum_of_digits_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }

            Console.WriteLine("Sum of digits: " + sum);
            Console.Read();
        }
    }
}
