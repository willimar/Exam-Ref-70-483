using System;
using System.Threading;

namespace _01___ThreadClass_Sample_3
{
    class Program
    {
        private static void MethodoThread(object value)
        {
            for (int i = 0; i < (int)value; i++)
            {
                Console.WriteLine("Thread proc: {0}", i);
                Thread.Sleep(0);
            }
        }

        static void Main(string[] args)
        {
            var t = new Thread(new ParameterizedThreadStart(MethodoThread));
            t.Start(5);
            t.Join();
            Console.WriteLine("Thread executando methodo parametrizado.");
            Console.Read();
        }
    }
}
