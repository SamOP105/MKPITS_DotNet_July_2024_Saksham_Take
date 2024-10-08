using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Convert_a_number_from_decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a decimal number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            Console.WriteLine("Binary: " + binary);
            Console.Read();
        }
    }
}
