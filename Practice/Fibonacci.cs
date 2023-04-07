using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Fibonacci
    {
        public void printFibonacci()
        {
            int inputLen = 10;
            int a = 0;
            int b = 1;
            int temp = 0;

            Console.Write("{0},{1}", a, b);
            for(int i=2; i<inputLen; i++)
            {
                temp = a + b;
                Console.Write("{0}", temp);
                a = b;
                b = temp;
            }
        }
        public void fibonacci_recursive()
        {
            int Inputlen = 10;
            fibonacci_rec(0, 1, 1, Inputlen);
        }

        private void fibonacci_rec(int a, int b, int counter, int Inputlen)
        {
            if(counter <= Inputlen)
            {
                Console.Write("{0}", a);
                fibonacci_rec(b, a + b, counter + 1, Inputlen);
            }
        }
    }
}
