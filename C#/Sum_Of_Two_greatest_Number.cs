using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_greatest_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp1 = 0, temp2 = 0;
            int count=Convert.ToInt32(Console.ReadLine());
            int[] array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0;i < count; i++)
            {
                
                if (temp2 < array[i])
                {
                    temp2 = array[i];
                }else if(temp1 < array[i])
                {
                    temp1= array[i];
                }
            }
            int Sum=temp1+ temp2;
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}
