using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_1
{
    public class Accountholder
    {
        string Name = " Saksham ";
        int age = 22;
        public virtual void getdetails()
        {
            Console.WriteLine("Name: " +Name +"\nAge: " + age);
        }
    }
    public class bankDetails : Accountholder
    {
        public override void getdetails()
        {
            Console.WriteLine("L");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Accountholder accountholder = new Accountholder();
            bankDetails bankDetails = new bankDetails();
            accountholder.getdetails();
            bankDetails.getdetails();
            Console.ReadLine();
        }
    }
}
