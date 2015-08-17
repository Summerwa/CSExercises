using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Mark:");
            int M;
            M=Convert.ToInt32(Console.ReadLine());
            if ((M<0)||(M>100))
            {
                Console.WriteLine("Error");  
            }
            else if ((M>=0)&&(M<40))
            {
                Console.WriteLine("the Grade is F"); 
            }
            else if ((M>=40) && (M<59))
            {
                Console.WriteLine("the Grade is C");
            }
            else if ((M>=60) && (M<=79))
            {
                Console.WriteLine("the Grade is B");
            }
            else if ((M>=80) && (M<=100))
            {
                Console.WriteLine("the Grade is A");
            }
        }
    }
}