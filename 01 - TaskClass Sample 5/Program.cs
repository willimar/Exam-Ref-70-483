using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_5
{
    class Program
    {
        private static Task SleepAsyncA(int milliseconds)
        {
            return Task.Run(() => { Thread.Sleep(milliseconds); });
        }

        private static Task SleepAsyncB(int milliseconds)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(milliseconds, -1);
            return tcs.Task;
        }

        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            SleepAsyncA(1000).Wait();
            Console.WriteLine("Tempo decorrido de {0}", watch.ElapsedMilliseconds);
            watch.Restart();
            SleepAsyncB(1000).Wait();
            Console.WriteLine("Tempo decorrido de {0}", watch.ElapsedMilliseconds);

            Console.ReadKey();
        }
    }
}
