using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {

            int number;
            int N = 0;

         for (number = 1; number<=1000; number++)
		{
			 
            for (int i = 1; i < number; i++)
               {
  
                  if (number % i == 0)
                  {
                       N = N + i;
                  }

               }

               if (number == N)
               {
                    Console.WriteLine("Perfect Number:{0}",number);
               }
               N = 0; 

          }

    
          
        }
    }
}
