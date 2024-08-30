/*Write a C program to check whether a given number is even or odd.
Test Data : 15
Expected Output :
15 is an odd integer*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n%2==0) {
                Console.WriteLine(n+" is an even integer");
            }
            else
            {
                Console.WriteLine(n+" is an odd integer");
            }
           Console.ReadLine();

        }
    }
}
