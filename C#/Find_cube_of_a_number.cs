﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Find_the_cube_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int cube = num * num * num;
            Console.WriteLine("Cube: " + cube);
            Console.Read();
        }
    }
}
