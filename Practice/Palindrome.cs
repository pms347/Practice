using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class Palindrome
    {
        public void palindrome_string()
        {
            string _inputstr, _reversestr = string.Empty;
            //Console.Write("Enter a string : ");
            //_inputstr = Console.ReadLine();
            _inputstr = "mohan";
            if (_inputstr != null)
            {
                for(int j= _inputstr.Length-1; j >= 0; j--)
                {
                    _reversestr += _inputstr[j].ToString();
                }
                
                if (_reversestr == _inputstr)
                {
                    Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
                else
                {
                    Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", _inputstr, _reversestr);
                }
            }
            Console.ReadLine();
        }

        public void palindrome_number()
        {
            string s, revs = "";
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--) //String Reverse  
            {
                revs += s[i].ToString();
            }
            if (revs == s) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);
            }
        }
    }
}
