using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int i;
            double  SalesSum = 0;
            double SalesAvg = 0;
            int[] sales = new int[12];
            double max=0;
            double min=0;
            
                
            for (i = 0; i < sales.Length; i++)
            {
                Console.Write("Enter sales for month {0}:", i);
                sales[i] = Convert.ToInt32(Console.ReadLine());
                SalesSum = SalesSum + sales[i];
                /* because max and min is in the loop ,if there is no limitation, any time sales[0] will be assigned to min and max.
                 another choice: you can just assume min equals to a very large number and max equals to 0.*/

                if (i==0)
                {
                max = sales[0];
                min = sales[0];
                }
                if (sales[i] > max)
                {
                    max = sales[i];
                }


                if (sales[i]<min)
                {
                    //Console.WriteLine("min - " + min);
                    //Console.WriteLine("sales[i] - " + sales[i]);
                    min = sales[i];
                }
                
            }
                SalesAvg = SalesSum / i;
                Console.WriteLine("Average Sales:{0}", SalesAvg);


                Console.WriteLine("Maximun Sales:{0}", max);
                Console.WriteLine();
                Console.WriteLine("min Sales:{0}", min);
                Console.WriteLine();

            

        }
    }
}
