using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance:");
            double D;
            double F, F1;
            D = Convert.ToDouble(Console.ReadLine());
            F = 2.4 + 0.4 * D;
            F1 = Math.Round(F, 1);
            if (F1 > F)
            {
                Console.WriteLine("the total fare is ${0:0.00}", F1);
            }
            else
            {
                Console.WriteLine("the total fare is ${0:0.00}", F1 + 0.1); Console.WriteLine();
            }
        }
    }
}

