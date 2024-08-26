using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace array13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Count=Convert.ToInt32(Console.ReadLine());
            decimal[] array = new decimal[Count];
            for (int i = 0; i < Count; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());

            }
            decimal sum = 0;
            for (int i = 0; i < Count; i++)
            {
                sum = sum + array[i];
            }
            decimal avg=sum / Count;
            Console.WriteLine(avg);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
