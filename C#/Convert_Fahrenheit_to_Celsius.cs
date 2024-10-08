using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Convert_Fahrenheit_to_Celsius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fahrenheit = 77;
            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + celsius);
        }
    }
}
