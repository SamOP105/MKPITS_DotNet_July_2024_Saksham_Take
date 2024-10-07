using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_white_spaces_in_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(s);

            int v = 0, c = 0, d = 0, space = 0;


            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                space++;
                }
            }
            Console.WriteLine("White Spaces: " + space);
            Console.Read();
        }
    }
}
