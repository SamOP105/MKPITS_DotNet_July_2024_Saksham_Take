using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_2nd_3rd_largest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count=Convert.ToInt32(Console.ReadLine());
            int[] array=new int[count];
            for(int i=0; i<count; i++)
            {
                array[i]=Convert.ToInt32(Console.ReadLine());

            }
            int temp1=0, temp2=0, temp3=0;
            for(int i=0; i < count; i++)
            {

                if(array[i] > temp1)
                {
                    temp3 = temp2;
                    temp2 = temp1;
                    temp1 = array[i];

                }
                else if (array[i] > temp2)
                {
                    temp3 = temp2;
                    temp2 = array[i];
                }
                else if (array[i] > temp3)
                {
                    temp3 = array[i];
                }
            }
            Console.WriteLine("1st: " + temp1 + " 2nd: " + temp2 + " 3rd: " + temp3);
            Console.WriteLine();
                Console.ReadLine();
        }
    }
}
