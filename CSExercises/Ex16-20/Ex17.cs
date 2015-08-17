using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter you name , gender and age:");
            string name = Console.ReadLine();
            string gender = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
        
            if ((gender == "F") && (age >= 40))
            {
                Console.WriteLine("Good Morning Aunty {0}", name);
            }
           
            else if ((gender == "F") && (age < 40))
            {
                Console.WriteLine("Good Morning Ms. {0}", name);
            }

            else if ((gender == "M") && (age >= 40))
            {
                Console.WriteLine("Good Morning Uncle {0}", name);
            }

            else if ((gender == "M") && (age < 40))
            {
                Console.WriteLine("Good Morning Mr. {0}", name);
            }
                 
        }
     }
 }

