using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double inverse = 0;
            double root = 0;
            double square = 0;

            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\t\tSQUARE");
            Console.WriteLine("=======================================================================");


            for (int i = 1; i < 11; i++)
            {
                inverse = 1.0 / i;
                root = Math.Sqrt(i);
                square = Math.Pow(i, 2);
                Console.WriteLine("{0:0.0##}\t\t{1:0.0##}\t\t{2:0.0##}\t\t\t{3:0.0##}", i, inverse, root, square);

            }

        }
    }
}
