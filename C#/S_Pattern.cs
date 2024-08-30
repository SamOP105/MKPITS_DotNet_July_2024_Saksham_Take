using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row <= 7; row++)
            {
                for (int  col= 1; col <= 4; col++)
                {
                    if (row == 1 &&( col==2 || col==3 )||
                        row==2 && (col==1 ||col==4 )||
                        row == 3 && (col == 1 ) ||
                        row == 4 &&(col == 2 || col == 3) || 
                        row == 5 &&( col == 4) ||
                        row == 6 && (col == 1 || col == 4) ||
                        row == 7 && (col == 2 || col == 3)) {
                        Console.Write("*");

                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
