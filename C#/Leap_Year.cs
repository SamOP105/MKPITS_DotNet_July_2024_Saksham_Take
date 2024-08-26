using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C program to find whether a given year is a leap year or not.
//Test Data : 2016

namespace C_Ass_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if (n / 4==0)
            {
                Console.WriteLine("Leap year.");
            }
            else
            {
                Console.WriteLine(" Not a Leap year");
            }
        }
    }
}
