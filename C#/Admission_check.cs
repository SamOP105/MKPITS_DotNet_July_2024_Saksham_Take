using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Ass_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Maths=Convert.ToInt32(Console.ReadLine());
            int Chem=Convert.ToInt32(Console.ReadLine());
            int Phy=Convert.ToInt32(Console.ReadLine());
            int Total= Maths+Chem+Phy;
            int MP=Maths+Phy;
            if( (Maths >= 65 && Chem>=50 && Phy >= 55) && (Total>=190) && (MP>=140))
            {
                Console.WriteLine("The candidate is eligible for admission");
            }else
            {
                Console.WriteLine("The candidate is not eligible for admission");
            }
            Console.ReadLine();
        }
    }
}
