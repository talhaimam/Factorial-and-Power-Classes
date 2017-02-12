using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Power
    {
        long p = 1;
        public void doPower(int b)
        {
            for (int i = 1; i <= 10; i++)
            {
                this.p = p * b;
                Console.WriteLine("{0} power of {1}",b,i+" is: "+p);
            }
        }
        public int RPower(int b, int power)
        {
            if (power != 0)
            {
                return b * RPower(b, power-1);
            }
            else
                return 1;
        }
    }
}
