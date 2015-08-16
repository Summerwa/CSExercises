using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert a double precision number:");
            double doublenumber;
            double square;
            doublenumber = Convert.ToDouble(Console.ReadLine());
            square = doublenumber * doublenumber;
            Console.WriteLine(square);  
        }
    }
}
