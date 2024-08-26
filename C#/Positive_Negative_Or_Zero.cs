using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
//Test Data : -5
//Expected Output :
//The value of n = -1


namespace C_Ass_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m=Convert.ToInt32(Console.ReadLine());
            int n = 0;
            if (m > 0)
            {
                n = 1;
            }else if (m == 0)
            {
                n = 0;
            }else if (n < 0)
            {
                n = -1;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
