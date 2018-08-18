using System;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Task<int>.Run(() => { return 42; });

            Console.Write(t.Result);
            Console.ReadKey();
        }
    }
}
