using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        
        {
            int[] A = new int[20] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i,temp=0;
            for (i = 0; i < (A.Length-1); i++)
            {
                if (A[i+1] >A[i])
                {
                    temp = A[i + 1];
                    Console.WriteLine("i={0}", i);
                    A[i+1] = A[i];
                    A[i] = temp;

                    
                   
                }
                for (int j = 0; j < A.Length; j++)
                {
                    Console.Write("{0}\t", A[j]);

                }

                Console.WriteLine("\n");

            } 

        }

    }
}
