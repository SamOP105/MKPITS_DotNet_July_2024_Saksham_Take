using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C program to find the largest of three numbers.
//Test Data : 12 25 52
//Expected Output :
//1st Number = 12,        2nd Number = 25,        3rd Number = 52
//The 3rd Number is the greatest among three

namespace C_Ass_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1=Convert.ToInt32(Console.ReadLine());
            int number2=Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The 1st Number is the greatest among three ");
            }else
            if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("The 2nd Number is the greatest among three ");
            }
            else
            if (number3 > number2 && number3 > number1)
            {
                Console.WriteLine("The 3rd Number is the greatest among three ");
            }
            Console.ReadLine();
        }
    }
    }
