using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.Write("Input your salary:");
            double salary;
            double income;
            salary = Convert.ToDouble(Console.ReadLine());
            income = salary + 0.1 * salary + 0.03 * salary;
            Console.WriteLine("The total income is:{0:0.00}", income);
        }
    }
}
