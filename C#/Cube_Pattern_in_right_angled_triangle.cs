using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 5; counter++)
            {
                int x = 1;int y = 1;
                for (int i = 1; i <= counter; i++)
                {
                    y=x* x;
                    Console.Write(y);
                    x++;
                }Console.WriteLine();
            }
            Console.Read();
        }   
    }
}
