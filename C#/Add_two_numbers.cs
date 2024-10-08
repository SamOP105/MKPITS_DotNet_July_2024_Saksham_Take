using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Add_two_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Sum: " + sum);
            Console.Read();
        }
    }
}
