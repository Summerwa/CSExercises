﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Input the distance:");
            double D;
            double F;
            D = Convert.ToDouble(Console.ReadLine());
            F = 2.4 + 0.4 * D;
            Console.WriteLine("the total fare is ${0}", F);

        }
    }
}
