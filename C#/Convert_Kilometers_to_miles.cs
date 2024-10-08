using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Convert_kilometers_to_miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter kilometers: ");
            double kilometers = Convert.ToDouble(Console.ReadLine());

            double miles = kilometers * 0.621371;
            Console.WriteLine("Miles: " + miles);
            Console.Read();
        }
    }
}
