using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Deligates
    {
        //Programmers often needs to pass a method as a parameter of other methods. For this purpose we create and use delegates.
        // https://www.c-sharpcorner.com/UploadFile/puranindia/C-Sharp-net-delegates-and-events/
        public static int num = 10;

        public delegate int intdelegate(int value);
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }
        public static int getNum()
        {
            return num;
        }
        public void TestDelegates()
        {
            intdelegate delegateTest = new intdelegate(AddNum);
            delegateTest(5);
            Console.WriteLine("Value of Num: {0}", getNum());
        }
       
    }
}
