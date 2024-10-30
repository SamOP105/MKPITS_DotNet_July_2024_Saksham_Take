using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Negate_the_Positive_Elements_of_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Console.WriteLine("Enter 5 Elements : ");
            for (int i = 0; i < 5; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
                if (a[i] > 0)
                    a[i] = -a[i];
            }
            Console.WriteLine("Elements:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();

        }
    }
}
