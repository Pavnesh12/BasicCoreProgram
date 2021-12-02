﻿using System;

namespace HarmonicSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double s = 0.0;

            Console.Write("Calculate the harmonic series and their sum\n");
            Console.Write("Input the number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms is : {1} \n", n, s);
        }
    }
}
