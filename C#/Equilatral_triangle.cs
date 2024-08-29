using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_Assignment_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int rows = 5;

                for (int i = 0; i < rows; i++)
                {
                    // Print spaces
                    for (int j = 0; j < rows - i - 1; j++)
                    {
                        Console.Write(" ");
                    }

                    // Print stars
                    for (int k = 0; k < 2 * i + 1; k++)
                    {
                        Console.Write("*");
                    }

                    // Move to the next line
                    Console.WriteLine();
                
                }Console.Read();

        }
    }
}
