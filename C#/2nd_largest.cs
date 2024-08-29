using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiD_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            Console.WriteLine("Enter Number");
            for (int loop = 0; loop < 3; loop++)
            {
                array[loop] = Convert.ToInt32(Console.ReadLine());

            }
            int temp = 0, temp1 = 0;
            for (int loop = 0; loop < 3; loop++)
            {
                if (temp < array[loop])
                {
                    temp1 = temp;
                    temp = array[loop];
                }
            }
            Console.WriteLine("Second Larget");
            Console.WriteLine(temp1);
            Console.ReadLine();
        }
    }
}
