using System;
using System.Threading;

namespace _01___ThreadClass_Sample_6
{
    class Program
    {
        private static ThreadLocal<int> _field = new ThreadLocal<int>(() => {
            return Thread.CurrentThread.ManagedThreadId;
        });

        static void Main(string[] args)
        {
            new Thread(new ThreadStart(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread proc A: {0}", i);
                }
            })).Start();

            new Thread(new ThreadStart(() => {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread proc B: {0}", i);
                }
            })).Start();

            Console.ReadKey();
        }
    }
}
