using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public delegate void MyDelegate();
    class Program

    {
        static void Main(string[] args)
        {
            string textA = "A - Hello World";
            string textB = "B - Hello World";

            //Create thread object to start them
            Thread threadA = new Thread(() => ThreadA(textA));
            Thread threadB = new Thread(() => ThreadA(textB));
            //Thread threadB = new Thread(ThreadB);
            Thread threadC = new Thread(ThreadC);

            Console.WriteLine("Threads started:");
            //Start Thread A, B, C
            threadA.Start();
            threadB.Start();
            threadC.Start();

            //Wait for the user to close the application
            Console.ReadKey();
        }

        public static void ThreadA(string param)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(param);
            }
        }

        public static void ThreadB(string param)
        {
            //String array with Hello World
            string[] helloWorld = { param, param, param, param };
            var data = helloWorld.ToList();

            //Thread B executed 4 times
            data.ForEach(m => { Console.WriteLine(m); });
        }

        public static void ThreadC()
        {
            //Execute thread C - The anonymous delegate
            AnDelegate tst = new AnDelegate();
            tst.HelloWorld();
        }
    }
}
