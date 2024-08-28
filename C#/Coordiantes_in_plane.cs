using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
//Test Data : 7 9
//Expected Output :
//The coordinate point (7,9) lies in the First quadrant.

namespace C_Ass_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 >= 0 && number2 >= 0)
            {
                Console.WriteLine("The coordinate point (" + number1 + "," + number2 + ") lies in the First quadrant");
            }
            else if (number1 < 0 && number2 >= 0)
            {
                Console.WriteLine("The coordinate point (" + number1 + "," + number2 + ") lies in the Second quadrant");
            }
            else if (number1 < 0 && number2 < 0)
            {
                Console.WriteLine("The coordinate point (" + number1 + "," + number2 + ") lies in the Third quadrant");
            }
            else if (number1 >= 0 && number2 < 0)
            {
                Console.WriteLine("The coordinate point (" + number1 + "," + number2 + ") lies in the Forth quadrant");
            }
            Console.ReadLine();

        }
    }
}