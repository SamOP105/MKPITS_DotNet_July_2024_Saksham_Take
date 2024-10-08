using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Calculate_the_simple_interest
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

            double interest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest: " + interest);
            Console.Read();
        }
    }
}
