using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
                Console.WriteLine("Enter a string:");
                string S = Console.ReadLine();

                char[] reversedArray = new char[S.Length];

                for (int i = S.Length-1; i >=0 ; i--)
                {
                    Console.WriteLine(S[i]);
                }

                
            Console.Read();
            
        }

    }
}

