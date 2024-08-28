using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ass_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Roll No: ");
            int Roll=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name of student: ");
            string Name=Console.ReadLine();
            Console.WriteLine("Marks in Physics: ");
            int phy=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks in Chemistry: ");
            int chem=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Marks in  Computer Application: ");
            int ca=Convert.ToInt32(Console.ReadLine());
            int Total = phy + chem + ca;
            Console.WriteLine("Total Marks: "+Total);
            int per = (Total / 3);
            Console.WriteLine("Percentage: "+per);
            if (per >= 80)
            {
                Console.WriteLine("First Division");
            }else if (per >=60 && per<80)
            {
                Console.WriteLine("Second Division");
            }
            else if (per >= 35 && per < 60)
            {
                Console.WriteLine("Third Division");
            }
            Console.ReadLine();

        }
    }
}
