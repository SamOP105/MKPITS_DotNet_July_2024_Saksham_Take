using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a C program to accept the height of a person in centimeters and categorize the person according to their height.
//Test Data : 135
//Expected Output :
//The person is Dwarf.


namespace C_Ass_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if (n < 150)
            {
                Console.WriteLine("The person is Dwarf");
            }else if(150<=n || n >= 170)
            {
                Console.WriteLine("This person is Normal");
            }else if(n >= 171)
            {
                Console.WriteLine("This person is huge");
            }
            Console.ReadLine();
        }
    }
}
