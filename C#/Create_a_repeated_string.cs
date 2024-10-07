using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_create_a_repeated_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string str =Console.ReadLine();
            int times = 3;
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += str;
            }
            Console.WriteLine(result);

            Console.Read();
        }
    }
}
