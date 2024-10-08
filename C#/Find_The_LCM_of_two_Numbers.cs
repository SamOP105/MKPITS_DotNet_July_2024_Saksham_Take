using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Find_the_LCM_of_two_numbers
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
            int a = 15, b = 20;
            int lcm = (a * b) / GCD(a, b);
            Console.WriteLine("LCM: " + lcm);
            Console.Read();
        
        }
    }
}
