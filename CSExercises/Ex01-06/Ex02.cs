﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Insert a Number:");
            int number;
            int square;
            number =Convert.ToInt32(Console.ReadLine());
            square=number*number;
            Console.WriteLine(square);
        }
    }
}
