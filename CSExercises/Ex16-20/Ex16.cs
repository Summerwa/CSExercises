using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter you name and gender:");
            string name=Console.ReadLine();
            string gender = Console.ReadLine();
            string a, b;
            if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms. {0}", name);
            }
            else
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            }
           
        }
    }
}