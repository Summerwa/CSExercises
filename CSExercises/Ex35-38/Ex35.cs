using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase:");
           
             string phrase = Console.ReadLine();

             int L;
            
             L=phrase.Length;
            
             Console.Write("the length of the string:{0}",phrase.Length);

             int i=0;
             int count = 0;
             int A = 0, B = 0, C = 0, D = 0, E = 0;

             do
             {


                 string r = phrase.Substring(i, 1);

                 if ((r=="a")||(r=="e")||(r=="i")||(r=="o")||(r=="u"))
                 {
                     count = count + 1;
                 }

                 if (r == "a")
                 {
                     A=A+1;
                 }


                 if (r == "e")
                 {
                     B = B + 1;
                 }

                 if (r == "i")
                 {
                     C = C + 1;
                 }

                 if (r == "o")
                 {
                     D = D + 1;
                 }


                 if (r == "u")
                 {
                     E = E + 1;
                 }
                 i = i + 1;


             } while (i < L);

             Console.WriteLine();
             Console.WriteLine("Total number of vowels:{0}", count);
             Console.WriteLine();
             Console.WriteLine("Number of a:{0}", A);
             Console.WriteLine("Number of e:{0}", B);
             Console.WriteLine("Number of i:{0}", C);
             Console.WriteLine("Number of o:{0}", D);
             Console.WriteLine("Number of u:{0}", E);

        }
    }
}
