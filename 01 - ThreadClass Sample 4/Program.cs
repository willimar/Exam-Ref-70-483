using System;
using System.Threading;

namespace _01___ThreadClass_Sample_4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stoped = false;

            var t = new Thread(new ThreadStart(() => {
                while (!stoped)
                {
                    Console.WriteLine("Runing...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press key to exit.");
            Console.ReadKey();
            stoped = true;
            t.Join();

            Console.WriteLine("Thread com variavel compartilhada.");
            Console.ReadKey();
        }
    }
}
