using System;
using System.Collections.Generic;
using System.Text;

namespace Basicprogramm
{
    public class Coin
    {
        double head = 0;
        double tail = 0;
     
       public Coin(int number)
        {
 
            Random random = new Random();
            for (int i = 0; i<number; i++)
            {
                int toss = random.Next(0, 2);
                if (toss == 1)
                {
                    head++;
                }
                else
                {
                    tail++;
                }


            }
            head = head * 100 / number;
            tail = tail * 100 / number;

        }
        public void percentage()
        {
            Console.WriteLine("percentage of head is:" + head);
            Console.WriteLine("percentage of tail is:" + tail);
        }
    }
  
}
