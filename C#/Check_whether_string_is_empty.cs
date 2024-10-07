using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Check_where_string_is_empty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool isEmpty = input.Length == 0;
            Console.WriteLine(isEmpty ? "String is empty" : "String is not empty");
            Console.Read();

        }
    }
}
