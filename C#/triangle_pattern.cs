using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
//     Write a program in C to make a pyramid pattern with numbers increased by 1.
//    1
//   2 3
//  4 5 6
//7 8 9 10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;  
            int num = 1;

            for (int itrate = 1; itrate <= n; itrate++)
            {
               
                for (int j = 1; j <= n - itrate; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= itrate; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }

                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
