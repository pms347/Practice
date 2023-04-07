using Practice.DesignPatterns;

namespace Practice
{
    class DesignPattern
    {
        public static void DesignPatternCall()
        {
            singleTonPattern();
        }
        private static void singleTonPattern()
        {
            SingletonPattern sinObj = SingletonPattern.GetInstance();
            SingletonPattern sinObj1 = SingletonPattern.GetInstance();
            SingletonPattern sinObj2 = SingletonPattern.GetInstance();
            SingletonPattern sinObj3 = SingletonPattern.GetInstance();
            sinObj.displayDetails();
        }
    }
}
