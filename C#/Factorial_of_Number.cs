using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int number=Convert.ToInt32(Console.ReadLine());
            int Factorial = 1;
            for (int itrate = 1; itrate <=number; itrate++)
            {
                Factorial=Factorial*itrate;
            }
            Console.WriteLine(Factorial);
            Console.Read();
        }
    }
}
