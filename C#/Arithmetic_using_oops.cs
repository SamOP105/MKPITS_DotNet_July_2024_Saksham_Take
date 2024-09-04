using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    internal class Program
    {
        public class Operator
        {
            double num1, num2;
            public Operator()
            {
                Console.WriteLine("Enter Two Numbers");
                num1=Convert.ToDouble(Console.ReadLine());
                num2=Convert.ToDouble(Console.ReadLine());
            }
            public void Add()
            {
                double Addition=num1 + num2;
                Console.WriteLine(Addition);
            }
            public void Sub()
            {
                double Subition=num1 - num2;
                    Console.WriteLine(Subition);

            }
            public void Mul()
            {
                double Mulition = num1 * num2;
                Console.WriteLine(Mulition);
            }
            public void Div()
            {
                double Divition=num1 / num2;
                Console.WriteLine(Divition);
            }

        }

        static void Main(string[] args)
        {
            Operator or = new Operator();
            or.Add();
            or.Sub();
            or.Mul();
            or.Div();
            Console.Read();
        }
    }
}
