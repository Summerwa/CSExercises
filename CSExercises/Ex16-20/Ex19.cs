using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the distance:");
            double D = Convert.ToDouble(Console.ReadLine());
           
            double F;

            if ((D > 0) && (D <= 0.5))
            {
                Console.WriteLine("The total fare is $2.4");
            }

            else
            {
                D = 10 * D;
                double D1 = Math.Ceiling(D);
                if (D <= 90) //multiply 10 here because i multiply 10 too D
                {
                    F = 2.4 + (D1 - 5) * 0.04;
                    Console.WriteLine("The total fare is ${0}", F);
                }
                else if (D > 90)
                {
                    F = 2.4 + 85 * 0.04 + (D1 - 90) * 0.05;
                    Console.WriteLine("The total fare is ${0}", F);
                }
            }
                
                        
        }
    }
}