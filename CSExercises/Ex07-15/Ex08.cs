using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a temperature in Centigrade scale:");
            double C;
            double F;
            C= Convert.ToDouble(Console.ReadLine());
            F =1.8*C+32;
            Console.WriteLine("The temperature in Fahrenheit scale is:{0}",F); 
        }
    }
}
