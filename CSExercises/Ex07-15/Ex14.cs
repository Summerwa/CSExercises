using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            double a, b, c,s,area,A;
            Console.Write("Input the side a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the side b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input the side c:");
            c = Convert.ToDouble(Console.ReadLine());
            s = (a + b + c) / 2;
            A = s * (s - a) * (s - b) * (s - c);
            area = Math.Sqrt(A);
            Console.WriteLine("the area is: {0}", area);

        }
    }
}