using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            string substr = "World";
            bool found = false;

            for (int i = 0; i <= str.Length - substr.Length; i++)
            {
                found = true;
                for (int j = 0; j < substr.Length; j++)
                {
                    if (str[i + j] != substr[j])
                    {
                        found = false;
                        break;
                    }
                }
                if (found)
                {
                    break;
                }
            }
            Console.WriteLine(found ? "Substring found: "+substr : "Substring not found: "+ substr);
            Console.ReadLine();
        }
    }
}
