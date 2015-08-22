using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex39
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please input a number:");
            double x = Convert.ToDouble(Console.ReadLine());
            long y = Factorial(x);
            Console.WriteLine("the factorial of this given number is:{0}", y);


        }

        public static long Factorial(double n)
        {

            long result = 1;
            if (n == 0)
            {


                result = 1;

            }

            else
            {

                for (int i = 1; i <= n; i++)
                {

                    // factorial: the expression result=1*i can not get the actual factorial result.
                    result = result * i;

                }

              
            }

            return result;
           
        }
    }
}
