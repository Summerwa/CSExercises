using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer:");
            int N = Convert.ToInt32(Console.ReadLine());
            bool tocompare = false;
            for (int i = 2; i <N; i++)
            {

                int r = N / i;
                int R = r * i;
                if (R == N)
                {
                    Console.WriteLine("This is not a prime number.");
                    tocompare = true;
                    break;
                }
               
            }
            if (tocompare==false)
            {
                Console.WriteLine("This is a prime number.");  
            }
            
           
 
        }
    }
}
