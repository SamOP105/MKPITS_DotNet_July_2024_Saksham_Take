
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_1
{
    public class Accountholder
    {
        string Name;
        int age;
        public void getDetails()
        {
            Name = "Saksham";
            age = 22;
            Console.WriteLine("Account Holder Name: " + Name + "\nAge: " + age);
        }
        public void getDetails(int X)
        {
            Console.WriteLine(X);
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountholder ac= new Accountholder();
            ac.getDetails();
            ac.getDetails(43);
            Console.Read();
        }
    }
}
