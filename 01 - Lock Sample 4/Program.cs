using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01___Lock_Sample_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken token = cancellationTokenSource.Token;

            var task = Task.Run(() => {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }
            }, token);

            Console.ReadKey();

            cancellationTokenSource.Cancel();

            Console.ReadKey();
        }
    }
}
