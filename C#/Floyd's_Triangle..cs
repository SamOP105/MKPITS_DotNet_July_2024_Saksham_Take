using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;


            Console.Write("Input the number of rows: ");
            number = int.Parse(Console.ReadLine());


            for (int iterate = 1; iterate <= number; iterate++)
            {
                for (int j = 1; j <= iterate j++)
                {

                    if ((iterate + j) % 2 == 0)
                    {
                        Console.Write("1");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
