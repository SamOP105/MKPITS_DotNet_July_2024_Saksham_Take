using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <=10; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }Console.Read();
        }
    }
}

