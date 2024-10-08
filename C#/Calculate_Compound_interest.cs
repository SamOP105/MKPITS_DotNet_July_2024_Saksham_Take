using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Calculate_compound_interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter principal: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time in years: ");
            int time = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of times interest applied per time period: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double amount = principal * Math.Pow((1 + rate / (n * 100)), n * time);
            Console.WriteLine("Compound Interest: " + (amount - principal));
            Console.Read();

        }
    }
}
