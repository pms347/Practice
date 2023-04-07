using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class InherExample
    {
        public void inherEx()
        {
            Base b1 = new Base();
            Base bd = new Deriv();
            //Deriv db = new Base(); //cannot implicitely convert base to deriv
            //nice example. I like to think it such that:
            //BaseClass: small basket
            //DerivedClass: big basket

            //you can pour all water
            //from small => to small
            //from big => to big
            //from small => to big

            //but not
            //from big => to small.it overflows. compiler gives error:)                                                                                                               
            Deriv d1 = new Deriv();

            b1.display();  // Base-Display
            bd.display();  // Base-Display
            d1.display();  // Derived-Display

        }
    }

    class Base
    {
        public void display()
        {
            Console.WriteLine("Base-Display");
        }
    }

    class Deriv : Base
    {
        public void display()
        {
            Console.WriteLine("Derived-Display");
        }
    }

    abstract class Shape
    {
        // abstract method
        public abstract int area();
    }

    class Square : Shape
    {

        // private data member
        private int side;

        // method of  square class
        public Square(int x = 0)
        {
            side = x;
        }

        // overriding of the abstract method of Shape
        // class using the override keyword
        public override int area()
        {
            Console.Write("Area of Square: ");
            return (side * side);
        }
    }
    class AbstrExample
    {
        public void absExp()
        {
            // creating reference of Shape class
            // which refer to Square class instance
            Shape sh = new Square(4);

            // calling the method
            double result = sh.area();

            Console.Write("{0}", result);
        }
    }
    public class virBase
    {
        public virtual void Test()
        {
            Console.WriteLine("This is the base version of the virtual method");
        }
    }
    public class virDerived : virBase
    {
        public override void Test()
        {
            Console.WriteLine("This is the derived version of the virtual method");
        }
    }

    class virfunctionality
    {
        public void Virfunctionality()
        {
            virBase baseObj1 = new virBase();
            baseObj1.Test(); // base version
            virBase baseObj2 = new virDerived();
            baseObj2.Test(); // derived version (becoz of override its derived version)
            virDerived baseObj3 = new virDerived();
            baseObj3.Test(); // derived version
        }
    }
}
