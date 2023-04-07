using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class ConstChaining
    {
        public ConstChaining() : this ("calling from base")
        {
            Console.WriteLine("Base Constructor");
        }

        public ConstChaining(string txt)
        {
            Console.WriteLine(txt);
            Console.WriteLine("Param Const");
        }
    }
}
