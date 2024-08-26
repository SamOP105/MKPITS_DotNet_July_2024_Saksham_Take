using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=Convert.ToInt32(Console.ReadLine());
            int[] array=new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int c=0;
            for (int i = 0; i < count; i++)
            {
                for (int j = i+1; j < count; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                        c++;
                    }
                }
            }
            Console.WriteLine("Numbers are: " + c);
            Console.ReadLine();
        }
    }
}
