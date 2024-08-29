using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] ladder = new int[4][]; 

                ladder[0] = new int[]{ 1};
            ladder[1] = new int[] { 2, 3 };
            ladder[2] = new int[] { 4, 5, 6 };
            ladder[3] = new int[] {7, 8, 9, 10 };

            foreach (int[] x in ladder)
            {
                foreach (int var in x)
                {
                    Console.Write(var);
                }Console.WriteLine();
            }
            Console.Read();
        
        } 
    }
}
