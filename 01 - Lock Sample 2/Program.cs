using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01___Lock_Sample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;

            var up = Task.Run(() => {
                for (int i = 0; i < 100000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 100000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);

            Console.ReadKey();
        }
    }
}
