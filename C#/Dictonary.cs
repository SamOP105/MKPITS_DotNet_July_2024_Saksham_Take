using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionry_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> myDict = new Dictionary<int,string>();
            myDict.Add(1, "Saksham");
            myDict.Add(2, "Neeraj");
            myDict.Add(3, "Shruti");
            myDict.Add(4, "Saqlin");
            myDict.Add(5, "Raksha");
            myDict.Add(6, "Nilesh");
            foreach(KeyValuePair<int,string> elements in myDict)
            {
                Console.WriteLine(elements.Key+" "+elements.Value);
            }Console.Read();

        }
    }
}
