using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int start = 6; 
            int length = 5;
            string substring = "";

            for (int i = 0; i < length; i++)
            {
                substring += input[start + i];
            }
            Console.WriteLine(substring);
            Console.Read();

        }
    }
}
