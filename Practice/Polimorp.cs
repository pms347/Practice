using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class Polimorp
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Add(string a, string b)
        {
            Console.WriteLine(a + b);
        }
        public virtual void Substract(int a, int b)
        {
            Console.WriteLine("from virtual");
            Console.WriteLine(b-a);
        }
    }
    public class DerClass : Polimorp
    {
        public override void  Substract(int a, int b)
        {
            Console.WriteLine("from override");
            Console.WriteLine(b - a);
        }
    }

}
