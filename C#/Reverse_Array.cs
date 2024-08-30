using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = count-1; i >=0; i--)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
