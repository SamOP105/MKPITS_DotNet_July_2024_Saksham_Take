using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_builder_concept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb= new StringBuilder("Saksham ");
            sb.Append("Take");
            sb.Insert(8,"Prabhakar  ");
            sb.Remove(18, 1);
            sb.Replace("Take", "Ingle");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
