using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_legth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();
            
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            Console.WriteLine(length);
            Console.ReadLine(); 
        }
    }
}
