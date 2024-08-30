using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Search_given_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count= Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());

            }
            int X=Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < count; i++)
            {
                if (X == array[i])
                {
                    Console.WriteLine("Array index: "+i);
                }
            }Console.WriteLine();
            Console.ReadLine();
        }
    }
}
