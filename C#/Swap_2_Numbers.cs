using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Swap_2_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 2 Numbers: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("a = " + a + ", b = " + b);
            Console.Read();
            
        }

    }
}

