using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n=123,Reverse= 0;
            while (n != 0)
            {
                int Remainder = n % 10;
                n = n / 10;
                Reverse = Reverse * 10 + Remainder;

            }
            Console.WriteLine(Reverse);
            Console.Read();
        }
    }
}
