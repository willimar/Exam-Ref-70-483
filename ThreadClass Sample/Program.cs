using System;
using System.Threading;

namespace ThreadClass_Sample
{
    class Program
    {
        private static void ThreadMethodo()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Thread proc: {0}", i);
                Thread.Sleep(new Random().Next(1, 2));
            }
        }

        static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMethodo));
            t.IsBackground = true;
            t.Start();

            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Main thread: do some work.");
                Thread.Sleep(new Random().Next(1, 2));
            }

            t.Join();

            Console.WriteLine("Simples exemplo de execução de thread.");
            Console.Read();
        }
    }
}
