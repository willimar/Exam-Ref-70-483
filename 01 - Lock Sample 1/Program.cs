using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01___Lock_Sample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This sample create a deadlock sample*/
            var lockA = new object();
            var lockB = new object();

            var up = Task.Run(() => {
                lock (lockA)
                {
                    Thread.Sleep(2000);
                    lock (lockB)
                    {
                        Console.Write("Locked A and B.");
                    }
                }
            });

            lock (lockB)
            {
                Thread.Sleep(2000);
                lock (lockA)
                {
                    Console.WriteLine("Locked B and A");
                }
            }

            up.Wait();
        }
    }
}
