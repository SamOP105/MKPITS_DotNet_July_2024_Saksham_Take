using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _3
{
    internal class Program
    {
//        Write a program in C to display the sum of the series[9 + 99 + 999 + 9999...].
//Test Data :
//Input the number or terms :5
//Expected Output :
//9 99 999 9999 99999
//The sum of the series = 111105
        static void Main(string[] args)
        {
            int number;
            long num = 9, sum = 0;


            Console.Write("Input the number of terms: ");
            number = Convert.ToInt32(Console.ReadLine());


            Console.Write("The series is: ");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(num + " ");
                sum += num;
                num = num * 10 + 9;
            }


            Console.WriteLine("\nThe sum of the series = " + sum);
            Console.Read();
        }
    }
}
