using System;
using System.Threading;

namespace _01___ThreadClass_Sample_2
{
    class Program
    {
        private static void ThreadMethodo()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread proc : {0}", i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            var t = new Thread(new ThreadStart(ThreadMethodo));

            /*If IsBackgroud for true a aplicação será fechada ao fim das execuções.*/
            t.IsBackground = false;
            t.Start();
            Console.WriteLine("If IsBackgroud for true a aplicação será fechada ao executar esta linha.");
        }
    }
}
