using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Convert_Celsius_to_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 25;
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Fahrenheit: " + fahrenheit);
            Console.Read();
        }
    }
}
