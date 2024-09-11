﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program in C to find the number and sum of all integers between
//100 and 200 which are divisible by 9.
//Expected Output :
//Numbers between 100 and 200, divisible by 9 :
//108 117 126 135 144 153 162 171 180 189 198
//The sum : 1683
namespace _13
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 100; i < 200; i++)
            {
                if(i % 9 == 0)
                {
                    Console.Write(" " + i);
                    sum += i;
                }
            }
            Console.WriteLine("Sum is: "+sum);
            Console.ReadLine();

        }
    }
}
