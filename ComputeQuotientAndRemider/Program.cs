using System;

namespace ComputeQuotientAndRemider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dividend and divisor\n");
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine()); 

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
           
        }
    }
}
