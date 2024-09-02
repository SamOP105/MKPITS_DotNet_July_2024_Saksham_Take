
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element "+i+": ");
                array[i] = int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("Duplicate elements in the array:");
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine(array[i]);
                        break; 
                    }
                }
            }
            Console.Read();
        }
    }
}
