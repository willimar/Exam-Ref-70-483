using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string[]> parent = Task.Run(() => {
                var result = new string[3];

                new Task(() => { result[0] = "Primeira task"; }, TaskCreationOptions.RunContinuationsAsynchronously).Start();
                new Task(() => { result[1] = "Segunda task"; }, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => { result[2] = "Terceira task"; }, TaskCreationOptions.AttachedToParent).Start();

                return result;
            });

            Thread.Sleep(100);

            var finalTask = parent.ContinueWith(
                parentTask => {
                    var v = parentTask.Result;
                    foreach (var item in v)
                    {
                        Console.WriteLine(item);
                    }
                });

            finalTask.Wait();

            Console.ReadKey();
        }
    }
}
