using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Male_Female_For_each
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countm=0; int countf = 0;
            Console.WriteLine("Enter:");
            int n=Convert.ToInt32(Console.ReadLine());
            char[]  c= new char[n];
            
            for (int row=0; row<n;row++)
            {
                c[row] = Convert.ToChar(Console.ReadLine());

            }
            foreach (char row in c)
            {
                if (row == 'm' || row == 'M')
                {
                    countm++;
                }
                else if (row == 'F' || row == 'f')
                {
                    countf++;
                }

            }
            Console.WriteLine(countm +"\t"+ countf);
            Console.ReadLine();

        }
        
    }
}
