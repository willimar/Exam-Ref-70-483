using System;
using System.Threading;

namespace _01_ThreadClass_Sample_5
{
    class Program
    {
        [ThreadStatic]
        private static int _field = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Com ThreadStatic atributo a variavel é a mesma mas não compartilhada entre as threads. Remova o atributo e faça o teste.");

            new Thread(new ThreadStart(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread proc A: {0}", _field);
                }
            })).Start();

            new Thread(new ThreadStart(() => {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread proc B: {0}", _field);
                }
            })).Start();

            Console.ReadKey();
        }
    }
}
