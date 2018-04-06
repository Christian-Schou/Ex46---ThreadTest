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
            //Strings for threads
            string textA = "A - Hello World";
            string textB = "B - Hello World";

            //Create thread object with lambda to start them
            Thread threadA = new Thread(() => ThreadA(textA));
            Thread threadB = new Thread(() => ThreadA(textB));
            Thread threadC = new Thread(() => ThreadC());

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
                //Print the param 4 times
                Console.WriteLine(param);
            }
        }

        public static void ThreadB(string param)
        {
            //String array with textB ("Hello World")
            string[] helloWorld = { param, param, param, param };
            //Convert the string array to a list for use with foreach
            var data = helloWorld.ToList();

            //Print all elements on their own line from the list with lambda
            data.ForEach(m => { Console.WriteLine(m); });
        }

        public static void ThreadC()
        {
            //Execute thread C - The anonymous delegate
            AnonymousDelegate tst = new AnonymousDelegate();
            tst.HelloWorld();
        }
    }
}
