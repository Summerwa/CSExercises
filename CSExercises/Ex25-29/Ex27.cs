using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            //27.a
            
            int x=0,y=0;

            Console.WriteLine("x\t\ty");
            Console.WriteLine("=====================================");

            for (x =-5;x<5;x++)
            {
                y = 2 * x * x - 4 * x + 3;


                Console.WriteLine("{0:0.0}\t\t{1:0.0}", x,y);
            }

            Console.WriteLine();
            Console.WriteLine();
            
            //27.b

            string r = "";

            for (x = 1; x < 21; x++)
            {
                y = 2 * x * x - 4 * x + 3;

                for(int i=1;i<y+1;i++)
                {
                   r=r+"*";
                }
                Console.WriteLine(r);
                r = "";

            }

        }
    }
}
