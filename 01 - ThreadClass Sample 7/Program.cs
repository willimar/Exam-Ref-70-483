using System;
using System.Threading;

namespace _01___ThreadClass_Sample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem((s) => {
                Console.WriteLine("Working on a thread from threadPool.");
            });

            Console.ReadLine();
        }
    }
}
