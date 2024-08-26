using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array= new int[6];
            array[0] = 2000;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1] = array[0]+1);
            Console.WriteLine(array[2] = array[1] + 1);
            Console.WriteLine(array[3] = array[2] + 1);
            Console.WriteLine(array[4] = array[3] + 1);
            Console.WriteLine(array[5] = array[4] + 1);
            Console.Read();
        }
      
    }
}
