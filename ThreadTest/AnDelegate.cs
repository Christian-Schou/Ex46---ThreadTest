using System;

namespace ThreadTest
{
    public class AnDelegate
    {
        public event MyDelegate del;

        public void HelloWorld()
        {
            del += () => Console.WriteLine("C - Hello World");
            del += () => Console.WriteLine("C - Hello World");
            del += () => Console.WriteLine("C - Hello World");
            del += () => Console.WriteLine("C - Hello World");
            del();
        }
    }
}