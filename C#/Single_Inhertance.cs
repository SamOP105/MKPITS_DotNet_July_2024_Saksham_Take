using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance_1
{
    public class Base{
        public void getData()
        {
            string Name = "Sbi Acc";
            int pin = 123;
            Console.WriteLine("Name: " + Name + "\npin: " + pin);
        }
    }
    public class Derived : Base
    {
        public void showData()
        {
            getData();
            Console.WriteLine("Branch Yavatmal...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Derived derived = new Derived();
            b.getData();
            derived.showData();
            Console.Read();
        }
    }
}
