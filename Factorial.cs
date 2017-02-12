using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task2
{
    class Factorial
    {
        int num;
        int num2 = 1;
        int num3 = 1;
        public int RecursiveFactorial(int n) //Recursive
        {
            this.num = n;
            if (num > 0)
            {
                num = num * RecursiveFactorial(num - 1);
                return num;
            }
            else
                return num=1;
        }
        public void dislpayFactorial()
        {
            Console.WriteLine("Factorial by recursive: "+num);
            Console.WriteLine("Factorial by for-loop:"+num2);
            Console.WriteLine("Factorial by while-loop:" + num3);
        }
        public int LoopFactorial(int n) //For-Loop
        {
            if (n > 0)
            {
                for (int i = 1; i <= n; ++i)
                {
                    this.num2 = num2 * i;
                }
                return num2;
            }
            else
            {
                return num2=1;
            }
        }
        public int WhileFactorial(int n) //While-loop
        {
            while (n > 0)
            {
                this.num3 = num3 * n;
                n--;
            }
            return 1;
        }
    }
}
