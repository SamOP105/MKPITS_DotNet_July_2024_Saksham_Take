using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Cube of "+i+" : " +i*i*i);
            }Console.ReadLine();
        }
    }
}
