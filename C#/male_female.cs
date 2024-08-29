using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Male_Female
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countM=0, countF=0;
            Console.Write("Enter No of Person:\n");
            int n=Convert.ToInt32(Console.ReadLine());
            char[] c = new char[n];
            Console.Write("Enter Person's gender");
            for(int i = 0; i < n; i++)
            {
                c[i]=Convert.ToChar(Console.ReadLine());
            }
            for (int row = 0; row < c.Length; row++)
            {
                if(c[row] == 'M'|| c[row]=='m')
                {
                    countM++;
                }
                else if (c[row] == 'F' || c[row] == 'f')
                {
                    countF++;
                }
                
            }
            Console.Write("person's are:\t");
            Console.Write("Males:"+countM + "\nFemales:" + countF);
            Console.Read();
        }
    }
}
