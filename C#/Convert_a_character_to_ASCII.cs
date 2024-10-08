using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Convert_a_character_to_its_ASCII_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a character: ");
            char ch = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("ASCII value: " + (int)ch);
            Console.Read();
        }
    }
}
