using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            int N=0;


          
               for (int i = 1; i < number; i++)
               {

                   if (number % i == 0)
                   {
                       N = N + i;
                   }

               }

               if (number == N)
               {
                   Console.WriteLine("Perfect Number");


               }

               else
               {
                   Console.WriteLine("Not Perfect Number");
               }
          
           

        }
    }
}
