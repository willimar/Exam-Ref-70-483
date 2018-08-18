using System;
using System.Threading;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<string[]> parent = Task.Run(()=> {
                var result = new string[3];

                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => result[0] = "Primeira parte");
                tf.StartNew(() => result[1] = "Segunda parte");
                tf.StartNew(() => result[2] = "Terceira parte");

                return result;
            });

            Thread.Sleep(100);

            var finalTask = parent.ContinueWith(parentTask => {
                foreach (var item in parentTask.Result)
                {
                    Console.WriteLine(item);
                }
            });

            finalTask.Wait();
            Console.ReadKey();
        }
    }
}
