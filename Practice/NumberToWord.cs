using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class NumberToWord
    {
        public NumberToWord()
        {
            Console.WriteLine("Enter the Number you want to print in Words: ");
            string inNum = Console.ReadLine();
            convertNumToWord(inNum);

        }


        private void convertNumToWord(string num)
        {
            //987654321
            string len = "987654321";
            int lenOf = len.Length;
            
            Console.WriteLine(lenOf);
        }
    }
}
