using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            double x1, y1, x2, y2; double square, distance;
            Console.Write("Input x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            square = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            distance=Math.Sqrt(square);
            Console.WriteLine("the distance between these two points is: {0:0.###}",distance);
        
        }
    }
}
