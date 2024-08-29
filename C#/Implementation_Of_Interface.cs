using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces_1
{
    class Base
    {

    }
    interface infB
    {
        void infBase();
    }
    class Derived : Base, infB
    {
        public void infBase()
        {
            Console.WriteLine("L");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.infBase();
            Console.Read();
        }
    }
}
