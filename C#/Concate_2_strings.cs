using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_concate_2_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = " World";
            string result = "";

            for (int i = 0; i < str1.Length; i++)
            {
                result += str1[i];
            }
            for (int i = 0; i < str2.Length; i++)
            {
                result += str2[i];
            }
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
