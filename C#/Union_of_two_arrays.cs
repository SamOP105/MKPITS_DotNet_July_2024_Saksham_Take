using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union_of_two_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of first array: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];
            Console.WriteLine("Enter elements of the first array:");
            for (int i = 0; i < n1; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter size of second array: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];
            Console.WriteLine("Enter elements of the second array:");
            for (int i = 0; i < n2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            int[] tempUnion = new int[n1 + n2];
            int unionSize = 0;

            for (int i = 0; i < n1; i++)
            {
                tempUnion[unionSize] = arr1[i];
                unionSize++;
            }

            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < unionSize; j++)
                {
                    if (arr2[i] == tempUnion[j])
                    {
                        break;
                    }
                    else if (j == unionSize - 1)
                    {
                        tempUnion[unionSize] = arr2[i];
                        unionSize++;
                    }
                }
            }

            Console.WriteLine("Union of the two arrays:");
            for (int i = 0; i < unionSize; i++)
            {
                Console.Write(tempUnion[i] + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
