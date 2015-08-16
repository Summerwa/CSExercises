using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            Console.Write("Input an integer:");
            int In;
            double Out;
            In = Convert.ToInt32(Console.ReadLine());
            Out = Math.Sqrt(In);
            Console.WriteLine("The square root is: {0}",Out);
            Console.WriteLine("Rounded: {0:0.000}", Out);
        }
    }
}
