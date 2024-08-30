using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size: ");
            int size=Convert.ToInt32(Console.ReadLine());
            int[,] arr=new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine("Enter Array Elements: ");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(arr[i, j]);
                }Console.WriteLine();
            }
            
            for (int i = 0; i < size; i++)
            {
                int sum = 0;
                //Console.WriteLine("Sum of arr[" + i + "," + j+"] is =");
                for (int j = 0; j < size; j++)
                {
                    sum=sum+arr[i, j];
                }Console.Write("The sum of Row "+i+" is: ");
                Console.WriteLine(sum);

            }
            Console.Read();


        }
    }
}
