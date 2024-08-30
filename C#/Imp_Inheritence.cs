using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevel_Inhenritance_1
{

    public class Base

    {
        public int id=7767;
        public void BaseFun(int X)
        {
            Console.WriteLine("Base Class: "+X);
        }

    }
    public class Intermediate: Base
    {
        public void InterFun()
        {
            Console.WriteLine("Inter Class");
        }

    }
    public class Derived: Intermediate
    {
        public void DerivedFun()
        {
            Console.WriteLine("Derived Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int b=Convert.ToInt32(Console.ReadLine());
            Derived d = new Derived();
            d.BaseFun(b);
            d.InterFun();
            d.DerivedFun();
            Console.WriteLine(d.id);
            Console.Read();
        }
    }
}
