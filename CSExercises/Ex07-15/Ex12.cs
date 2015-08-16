using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance:");
            double D;
            double F;
            D = Convert.ToDouble(Console.ReadLine());
            F = 2.4 + 0.4 * D;
            F = Math.Round(F,1);
            Console.WriteLine("the total fare is ${0:0.00}",F);   
        }
    }
}
