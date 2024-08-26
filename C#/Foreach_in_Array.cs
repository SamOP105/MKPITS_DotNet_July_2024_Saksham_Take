using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0;
            int Count=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[Count];
            for(int i=0; i<array.Length; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }
            foreach(int i in array)
            {
                Sum=Sum+i;
            }
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}

