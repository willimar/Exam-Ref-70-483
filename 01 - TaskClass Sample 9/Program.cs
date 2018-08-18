using System;
using System.Collections.Concurrent;
using System.Linq;

namespace _01___TaskClass_Sample_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcurrentStack<int> stak = new ConcurrentStack<int>();

            stak.Push(42);

            int result;

            if (stak.TryPop(out result))
            {
                Console.WriteLine("Popped: {0}", result);
            }

            stak.PushRange(new int[] { 1, 2, 3, 55 });

            int[] values = new int[3];
            stak.TryPopRange(values);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
