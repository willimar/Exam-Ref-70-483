using System;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Task.Run(() => {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("*");
                }
            });

            t.Wait();
            Console.ReadKey();
        }
    }
}
