using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35_Trim_End_using_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            Console.WriteLine("Trim A string: " + s.TrimEnd());
            Console.ReadLine();
        }
    }
}
