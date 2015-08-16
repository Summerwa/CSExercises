using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("input a double precision number:");
            double In;
            double Out;
            In = Convert.ToDouble(Console.ReadLine());
            Out = Math.Sqrt(In);
            Console.WriteLine("square root={0}", Out);
            Console.WriteLine("Rounded={0:0.000}", Out);
        }
    }
}
