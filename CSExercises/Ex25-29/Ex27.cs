using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
        int x=0,y=0;


            Console.WriteLine("x\t\ty");
            Console.WriteLine("===========================================");

            for (x =-5;x<5;x++)
            {
                y = 2 * x * x - 4 * x + 3;


                Console.WriteLine("{0:0.0}\t\t{1:0.0}", x,y);
            }
                


        }
    }
}
