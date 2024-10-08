using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Find_the_GCD_of_two_numbers
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }
        static void Main(string[] args)
        {
            int a = 56, b = 98;
            Console.WriteLine("GCD: " + GCD(a, b));
            Console.Read();
            
        }
    }
}