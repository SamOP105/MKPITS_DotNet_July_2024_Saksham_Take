using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Fibonacci_sequence_up_to_n_terms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10, a = 0, b = 1, c;

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
                
            }
            Console.Read();
        }
    }
}
