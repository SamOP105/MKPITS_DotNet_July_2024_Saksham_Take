using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Non_repeated_words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string input = Console.ReadLine();
            char firstNonRepeated = '\0'; // Initialize to null character
            for (int i = 0; i < input.Length; i++)
            {
                bool repeated = false;
                for (int j = 0; j < input.Length; j++)
                {
                    if (i != j && input[i] == input[j])
                    {
                        repeated = true;
                        break;
                    }
                }
                if (!repeated)
                {
                    firstNonRepeated = input[i];
                    break;
                }
            }
            Console.WriteLine(firstNonRepeated);
            Console.Read();
        }
    }
}
