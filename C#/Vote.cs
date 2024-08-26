using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C program to read the age of a candidate and determine whether he is eligible to cast his/her own vote.
//Test Data : 21
//Expected Output :
//Congratulation!  You are eligible for casting your vote.


namespace C_Ass_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age=Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("Congratulation!  You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible for casting your vote.");
            }
            Console.ReadLine();
        }
    }
}
