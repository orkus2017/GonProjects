using System;
using System.Threading;

namespace _70_483_Chapter_1._1_ThreadMethod
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);//PAsa el control a otros hilos
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }
            t.Join();//Espera a que termine el hilo t para proseguir

            Console.ReadKey();
        }
    }
}
