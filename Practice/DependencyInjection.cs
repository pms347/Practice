using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    //It allows us to develop loosely-coupled code. The intent of Dependency Injection is to make code maintainable.
    //Dependency Injection helps to reduce the tight coupling among software components. 
    //Dependency Injection reduces the hard-coded dependencies among your classes by injecting those dependencies at run time 
    //instead of design time technically.
    //*** Not following Dependency Injection  ***
    public static class NonDependencyInjection
    {
        public static void checkDP()
        {
            //create object for logger text
            logtext objlogtext = new logtext();
            //create object for logger DB
            logdatabase objlogDB = new logdatabase();
            //Problem --> If we want to add new logger then we need to create new object for that class and have to include in catch block
            // which makes code complex for maintainable and also tightly coupled 
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception msg)
            {
                objlogtext.loggerText(msg.Message);
                objlogDB.loggerText(msg.Message);
            }
        }
    }
    public class logtext
    {
        public void loggerText(string message)
        {
            Console.WriteLine("log in text" + message);
        }
    }
    public class logdatabase
    {
        public void loggerText(string message)
        {
            Console.WriteLine("log in Database" + message);
        }
    }

    //*** Following Dependency Injection ***
    public static class DependencyInjection
    {
        public static void CheckDP()
        {
            string loggerType = "Text";
            ILogger ilogger;
            switch (loggerType)
            {
                case "Text":
                    ilogger = new logtext1();
                    break;
                case "Database":
                    ilogger = new logdatabase1();
                    break;
                default:
                    ilogger = null;
                    break;
            }
           logManager logMan = new logManager(ilogger);
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception msg)
            {
                logMan.log(msg.ToString());
            }
        }
    }

    public class logManager
    {
        private ILogger _logger;
        public logManager(ILogger loggerState){
            _logger = loggerState;
            }
        public void log(string msg)
        {
            _logger.logger(msg);
        }
    }

    public class logtext1:ILogger
    {
        public void logger(string message)
        {
            Console.WriteLine("log in text" + message);
        }
    }
    public class logdatabase1: ILogger
    {
        public void logger(string message)
        {
            Console.WriteLine("log in Database" + message);
        }
    }

    public interface ILogger{
        void logger(string message);
    }
}

//Refernce:
//https://www.youtube.com/watch?v=7eQKYD-xRTQ