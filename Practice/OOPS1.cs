using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class OOPS1
    {
        // OOPS Example with constuctors.
        public void OOPSExamples()
        {
            OOPSSimple();
            //OOPSwithABSClass();
            //OOPSWithABSANDInter();
            //OOPsWithMultiInterface();
        }

        public void OOPSSimple()
        {
            Console.WriteLine("------------------OOPSSimple-----------------------");
            A objA = new A();
            objA.display();
            Console.WriteLine("-----------------------------------------");
            B objB = new B();
            objB.display();
            Console.WriteLine("-----------------------------------------");
            A objAB = new B();
            objAB.display();

            //left type, right class name
            // objA is a object of class A with type A so first it will call a constructor of class A then creates objA with type of A
            // then it calls a method of its own type for ex.the type of objA is A so it will call A.display();
        }

        public void OOPSwithABSClass()
        {
            Console.WriteLine("------------------OOPSwithABSClass-----------------------");
            Baseclass objAbsC = new C();
            objAbsC.absDisp();
            objAbsC.display();
            Console.WriteLine("-----------------------------------------");
            C objC = new C();
            objC.absDisp();
            objC.display();

        }

        public void OOPSWithABSANDInter()
        {
            Console.WriteLine("------------------OOPSWithABSANDInter-----------------------");
            D objD = new D();
            objD.absDisp();
            objD.display();
            objD.display1();
            objD.display2();
            Console.WriteLine("-----------------------------------------");
            Baseclass objAbsD = new D();
            objAbsD.absDisp();
            objAbsD.display();
            Console.WriteLine("-----------------------------------------");
            oopsExample1 objinterD = new D();
            objinterD.display1();

        }

        public void OOPsWithMultiInterface()
        {
            Console.WriteLine("------------------OOPsWithMultiInterface-----------------------");
            E objE = new E();
            objE.display();
            objE.display1();
            objE.display2();
            objE.interDisp1();
            objE.interDisp2();

            Console.WriteLine("-----------------------------------------");

            oopsExample1 objinterE = new E();
            objinterE.display1();
            objinterE.interDisp1();

            Console.WriteLine("-----------------------------------------");

            oopsExample2 objinter2E = new E();
            objinter2E.display2();
            objinter2E.interDisp2();

        }

        public void TestOverload()
        {
            OverloadMthod(1, 2);
        }

        private void OverloadMthod(int a, int b)
        {
            Console.WriteLine("INt: {0}",(a+b));
        }
        private void OverloadMthod(long a, long b)
        {
            Console.WriteLine("Long: {0}", (a + b));
        }
    }

    abstract class Baseclass
    {
        public Baseclass()
        {
            Console.WriteLine("Constructor - Absclass Baseclass");
        }
        public void display()
        {
            Console.WriteLine("Display - Absclass Baseclass");
        }

        public abstract void absDisp();

        public abstract void testflow();

    }
    class A
    {
        public A()
        {
            Console.WriteLine("Constructor - Class A");
        }

        public void display()
        {
            Console.WriteLine("Display - Class A");
        }
    }

    class B : A
    {
        public B()
        {
            Console.WriteLine("Constructor - Class B");
        }

        public void display()
        {
            Console.WriteLine("Display - Class B");
        }
    }

    class C : Baseclass
    {
        public C()
        {
            Console.WriteLine("Constructor -Class C");
        }

        public override void absDisp()
        {
            Console.WriteLine("absDisp - absclass method override in c");
        }

        public void display()
        {
            Console.WriteLine("Display - Class C");
        }

        public override void testflow()
        {
            throw new NotImplementedException();
        }
    }

    interface oopsExample1
    {
        void interDisp1();
        void display1();

        static string name_inter = "";

        int MyProperty { get; set; }

    }

    interface oopsExample2
    {
        public void interDisp2();
        public void display2();

    }

    class D : Baseclass, oopsExample1
    {
        public D()
        {
            Console.WriteLine("Constructor - D");
        }

        public int MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void absDisp()
        {
            Console.WriteLine("Display - absclass method override in D");
        }

        public void display()
        {
            oopsExample1.name_inter = "";
            Console.WriteLine("Display - Class D");
        }

        public void display1()
        {
            Console.WriteLine("Display - Interface 1 class D");
        }

        public void display2()
        {
            Console.WriteLine("Display - Interface 2 class D");
        }

        public void interDisp1()
        {
            Console.WriteLine("interDisp1 - Interface 1 Class D");
        }

        public void interDisp2()
        {
            Console.WriteLine("interDisp2 - Interface 2 Class D");
        }

        public override void testflow()
        {
            throw new NotImplementedException();
        }
    }

    class E : oopsExample1, oopsExample2
    {
        int oopsExample1.MyProperty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public E()
        {
            Console.WriteLine("Constructor - E");
        }
        public void display2()
        {
            Console.WriteLine("Display - Interface 2 class E");
        }

        public void display1()
        {
            Console.WriteLine("Display - Interface 1 class E");
        }

        public void interDisp1()
        {
            Console.WriteLine("interDisp1 - Interface 1 class E");
        }

        public void interDisp2()
        {
            Console.WriteLine("interDisp2 - Interface 2 class E");

        }

        public void display()
        {
            Console.WriteLine("Display - class E");
        }


        class TestFinal
        {
            
        }
    }
    public class pvtCons
    {
        private pvtCons()
        {
            Console.WriteLine("Private Cons");
        }
        public static void display()
        {
            Console.WriteLine("Disply Method");
        }
    }
}
