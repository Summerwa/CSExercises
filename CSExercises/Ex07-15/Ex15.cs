using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.Write("input 3 digit number which is from 100 to 999:");
            int a, b, c, D,D0;
            D = Convert.ToInt32(Console.ReadLine());
            a = D / 100;
            b = D % 100 / 10;
            c = D % 100 % 10;
            D0=100*a+10*b+c;
            D=Convert.ToInt32(Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3));
            if (D == D0)
            {
                Console.WriteLine("This is an Armstrong number");
            }
            else
            {
                Console.WriteLine("This is not an Armstrong number");
            }

        }
    }
}