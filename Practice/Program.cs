using System;
using static Practice.E;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------->>");
            ////--------- Inheritance -----------//
            //InherExample InherObj = new InherExample();
            //InherObj.inherEx();

            ////--------- Abstraction -----------//
            //AbstrExample AbsObj = new AbstrExample();
            //AbsObj.absExp();

            //----------- virtual ---------------//
            //virfunctionality virtualobj = new virfunctionality();
            //virtualobj.Virfunctionality();

            //----------- Generics ---------------//
            //Generics genObj = new Generics();
            //genObj.genericMethod<int>("INT", 10);
            //genObj.genericMethod<string>("STRING", "TEN");
            //genObj.genericMethod<bool>("BOOL", true);

            //--------- Delegates -------------------//
            //Deligates delegateObj = new Deligates();
            //delegateObj.TestDelegates();

            //--------- palindrome ------------------//
            //Palindrome pali = new Palindrome();
            //pali.palindrome_string();
            //pali.palindrome_number();

            //------ fibonacci -----------------//
            //Fibonacci fibo = new Fibonacci();
            //fibo.fibonacci_recursive();
            //fibo.printFibonacci();

            //------------ No of occurances of word ----------------//
            //NoOfOccurancesWord noofword = new NoOfOccurancesWord();
            //noofword.getStringOccurances();

            //----------- sorting ---------------//
            //Sorting sort = new Sorting();
            //sort.sortStringAsc();
            //sort.sortStringDesc();
            //sort.sortNumAsc();
            //sort.sortNumDesc();

            //---------------OOPS1------------------------//

            //OOPS1 oops1obj = new OOPS1();
            //oops1obj.TestOverload();

            //-----Async------------ -//
            //AyncExample.AyncExampleMain();

            //NonDependencyInjection.checkDP();

            //Linq
            LinqExample objLinq = new LinqExample();

            //pvtCons.display();

            //ConstChaining objConsChain = new ConstChaining();


            //Design Pattern
            //DesignPattern.DesignPatternCall();


            //WebAPIExample wex = new WebAPIExample();
            //wex.Metho();

            //forloopExample.forExamp();

            //Polimorp test =  new Polimorp();
            //test.Add(1,2);
            //test.Add("a", "b");
            //test.Substract(1, 2);

            //Polimorp test1 = new DerClass();
            //test1.Substract(1, 2);

            //DerClass test2 = new DerClass();
            //test2.Substract(1, 2);

        }
    }
}
