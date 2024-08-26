using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. Of Employees");
            int n=Convert.ToInt32(Console.ReadLine());
            int[] id = new int[n];
            string[] emp = new string[n];
            for (int i = 0; i < n; i++) {
            id[i] = Convert.ToInt32(Console.ReadLine());
        }
            for (int i = 0; i < n; i++) {
                emp[i]= Console.ReadLine();
            }
            Console.WriteLine("Emp. No   Emp. Name");
            for (int work = 0; work < n; work++) {

                Console.Write(id[work] + "             " + emp[work]);
                Console.WriteLine();
            }
            
            Console.Read();
        }
    }
}
