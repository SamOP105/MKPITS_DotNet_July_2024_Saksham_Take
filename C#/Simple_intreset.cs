using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    public class Interest
    {
        double principal;
        double year;
        double rate;

        
        public Interest()
        {
            Console.WriteLine("Enter: ");
            principal= Convert.ToDouble(Console.ReadLine());
            year =Convert.ToDouble(Console.ReadLine());
            rate=Convert.ToDouble(Console.ReadLine());
            
        }

        
        public void InterestX()
        {
            double SimpleInterest= (principal*rate*year)/100;
            Console.WriteLine("Simple Intreset:"+SimpleInterest);
        }

        
        

        static void Main(string[] args)
        {
            Interest In =new Interest();
            In.InterestX();
            Console.Read();

           
        }
    }

}
