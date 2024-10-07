using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Count_the_Number_of_Unique_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int uniqueCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (input[i] == input[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique && input[i] != ' ')
                {
                    uniqueCount++;
                }
            }
            Console.WriteLine(uniqueCount);
            Console.ReadLine();

        }
    }
}
