using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01___Lock_Sample_3
{
    class Program
    {
        static int value = 1;

        static void Main(string[] args)
        {
            var t1 = Task.Run(() => {
                if (value == 1)
                {
                    Thread.Sleep(1000);
                    Interlocked.CompareExchange(ref value, 2, 1);
                    if (value == 2)
                    {
                        Console.WriteLine("Value was 2.");
                    }
                }
            });

            var t2 = Task.Run(() => {
                Thread.Sleep(3000);
                value = 3;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
