﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            Console.Write("input a double precision number:");
            double In;
            double Out;
            In= Convert.ToDouble(Console.ReadLine());
            Out = Math.Sqrt(In);
            Console.WriteLine(Out);
        }
    }
}
