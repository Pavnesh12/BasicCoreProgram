using System;

namespace SwapTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp =0;
            Console.WriteLine("enter two number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("swap number is ", +number1, +number2);


        }
    }
}
