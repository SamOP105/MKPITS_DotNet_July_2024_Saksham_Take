using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Find_the_average_of_n_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine("Average: " + (sum / n));
            Console.Read();
        }
    }
}
