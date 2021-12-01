using System;

namespace Basicprogramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("welcome to basic core program");
          int n =  Convert.ToInt32(Console.ReadLine());
            Coin c = new Coin(n);
            c.percentage();

        }
    }
}
