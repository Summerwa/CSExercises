using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
         //25a

            Console.WriteLine("Please give a integer:");
            int N = Convert.ToInt32(Console.ReadLine());

            int Total = 1;

            for (int i = 1; i <=N; i++)
            {

                Total = Total * i;
            }

            Console.WriteLine("the factorial of {0} is {1}", N, Total);
           
            //25b

            int Total2 = 1;
           
            for (int j = N; j >=1; j--)
            {

                Total2 = Total2 * j;

            }

            Console.WriteLine("the factorial of {0} is {1}", N, Total2);




        }
    }
}
