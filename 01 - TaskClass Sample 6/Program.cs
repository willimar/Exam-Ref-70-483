using System;
using System.Linq;

namespace _01___TaskClass_Sample_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Enumerable.Range(0, 10);

            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("**************************");

            parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).ToArray();

            foreach (var item in parallelResult)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
