using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B, C, X, HCF, LCM;
            Console.WriteLine("Enter one integer numbers A:");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter one integer numbers B:");
            B = Convert.ToInt32(Console.ReadLine());
            C = A * B;
            do
            {
                 if (A == B)
                    X = A;
                else if (A < B)
                    B = B - A;
                else if (A > B)
                    A = A - B;
            } while (A!=B);
            X = A;  
            HCF = X;
            Console.WriteLine("HCF={0}", HCF);
            LCM = C/ HCF;
            Console.WriteLine("LCM={0}", LCM);
        
        }
    }
}
