using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.DesignPatterns
{
    class SingletonPattern
    {
        /*
        Singleton pattern ensures a class has only one instance and provides a global point of access to it
        Ex:
        printing - print one by one
        database connection class
        Error Log         - log error one by one
        

        Rules for Singleton
        can have only one object 
        Should contains private constructor. - it protects for inheritance
        All the members and member function, are static. -  easy to access with help of class name 
        Have to check object availability, before creating an object.

        lazy initialization. - when we required object that time only obj is created so it takes low memory.


        for multi threading (instanceVariable == null) this case will fail. so to acheive that we have to use lock(instanceVariable)
        */

        private SingletonPattern()
        {

        }

        public static SingletonPattern instanceVariableSingleton;
        private static readonly object mulObj = new object(); // for multithreading
        public  static SingletonPattern GetInstance()
        {
            lock (mulObj) ; // for multithreading

            if (instanceVariableSingleton == null)
            {
                instanceVariableSingleton = new SingletonPattern();
                Console.WriteLine("object created");
            }

            return instanceVariableSingleton;
        }

        public void displayDetails()
        {
            Console.WriteLine("singleton pattern invoked");
        }

        
    }
}
