using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please input a sentence:");
            string a = Console.ReadLine();
            string[] r = a.Split(' ');

            string newword = "";
            
            for (int i = 0; i < r.Length; i++)
            {
                Console.WriteLine(r[i]);
                //array assign to string 
               string word = r[i];

                //just in case word=space=" "
                // if word=space, the length of word is 0

                if (word.Length>1)
                {

                    word = word.ToUpper().Substring(0, 1) + word.Substring(1, word.Length - 1);


                    newword = newword + word + " ";

                }

                else if (word.Length==1)
                {
                    word = word.ToUpper().Substring(0, 1);
                    newword = newword + word + " ";
                }
            
           
            }

            Console.WriteLine("the given sentence is converted to title case:{0}",newword);







        }
    }
}
