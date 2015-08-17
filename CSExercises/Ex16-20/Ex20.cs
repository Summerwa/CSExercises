using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity for TV:");
            int Qt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity for DVD:");
            int Qd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the quantity for MP3:");
            int Qm = Convert.ToInt32(Console.ReadLine());

            int TP, P;
            double tp = 0;
            P = Qt * 900 + Qd * 500;
            TP = P + Qm * 700;
            if ((TP > 5000) && (TP <= 10000))
            {
                tp = P * (1 - 0.1) + Qm * 700;
            }
            else if ((TP > 10000))
            {
                tp = P * (1 - 0.15) + Qm * 700;
            }
            Console.WriteLine("Total Price for this order is:$ {0}", tp);
        }
    }
}