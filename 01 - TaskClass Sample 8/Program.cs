using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new ConcurrentBag<int>();
            Task.Run(() => {
                bag.Add(42);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
                bag.Add(21);
            });

            Task.Run(() => {
                foreach (var i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();

            Console.ReadKey();
        }
    }
}
