using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Console.Write("Input a number: ");
            int number = int.Parse(Console.ReadLine());

            
            if (IsArmstrong(number))
            {
                Console.WriteLine(number+" is an Armstrong number");
            }
            else
            {
                Console.WriteLine(number+" is not an Armstrong number");
            }
            Console.Read();
        }

        static bool IsArmstrong(int number)
        {
            int originalNumber = number;
            int sum = 0;
            int digits = number.ToString().Length;

            while (number > 0)
            {
                int digit = number % 10;
                int power = 1;

                
                for (int i = 0; i < digits; i++)
                {
                    power *= digit;
                }

                sum += power;
                number /= 10;
            }

            return sum == originalNumber;
            
        }
        
    }
}
