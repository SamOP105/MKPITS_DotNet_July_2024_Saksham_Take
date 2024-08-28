using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Odd numbers are: ");
            for (int i = 1; i <=2*n; i++)
            {
                Console.WriteLine(i);
                sum = sum + i;
                i++;
            }Console.WriteLine(sum);
            Console.Read();
        }
    }
}
