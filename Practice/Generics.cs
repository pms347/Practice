using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Generics
    {
        public void genericMethod<Type>(string Test, Type GenrParam)
        {
            Console.WriteLine("{0} : {1}", Test, GenrParam);
        }
    }
}
