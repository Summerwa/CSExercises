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

             Console.WriteLine("the length of the string:{0}",phrase.Length);

             int i=0;
             int count = 0;

             do
             {


                 string r = phrase.Substring(i, 1);

                 if ((r=="a")||(r=="e")||(r=="i")||(r=="o")||(r=="u"))
                 {
                     count = count + 1;
                 }
               
                 i = i + 1;


             } while (i < L);


             Console.WriteLine("Total number of vowels:{0}", count);

        }
    }
}
