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
            //                       0   1   2   3   4  5   6    7   8   9   10  11 12  13  14  15  16  17  18  19 
            int[] A = new int[20] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int temp=0;
            
            for (int i = 0; i < (A.Length-1); i++)
            {

                for (int j = i+1; j < A.Length; j++)
                {
                    
                    if (A[j] > A[i])
                    {
                        temp = A[j];
                        A[j] = A[i];
                        A[i] = temp;
                        Console.WriteLine("i - " + i);
                        Console.WriteLine("j - " + j);
                        for (int k = 0; k < A.Length ; k++)
                        {
                            Console.Write(A[k] + "\t");
                            Console.WriteLine("k = " + k);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("====================");
                       
                    }
                   
                }
                
                
            }
            

        }

    }
}
