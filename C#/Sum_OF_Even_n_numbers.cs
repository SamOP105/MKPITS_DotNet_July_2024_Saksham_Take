using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
//    Write a C program to display the sum of n terms of even natural numbers.
//    Test Data :
//Input number of terms : 5
//Expected Output :
//The even numbers are :2 4 6 8 10
//The Sum of even Natural Number upto 5 terms : 30
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number:");
            int Number=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Even Numbers : ");
            int Sum = 0;
            for (int iterate = 2; iterate <=2 * Number; iterate++)
            {
                Sum += iterate;
                Console.WriteLine(iterate);
                iterate++;
            }
            Console.WriteLine(Sum);
            Console.Read();
                
        }
    }
}
