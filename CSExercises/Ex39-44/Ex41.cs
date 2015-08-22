using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex41
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Please input a string s1:");

            string s1 = Console.ReadLine();

            Console.WriteLine("Please input a string s2:");

            string s2 = Console.ReadLine();

            bool result = InString(s1, s2);

            if (result == true)
            {
                Console.WriteLine("string s2 occurs in string s1");

            }
            else
            {
                Console.WriteLine("string s2 does not occur in string s1");
            }

        }


        public static bool InString(string s1, string s2)
        {

            int result = 0, i;
            if (s2.Length <= s1.Length)
            {

                for (i = 0; i < s1.Length - s2.Length + 1; i++)
                {

                    string s1part = s1.Substring(i, s2.Length);
                    result = s1part.CompareTo(s2);
                    if (result == 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
            return true;

        }


    }
}
