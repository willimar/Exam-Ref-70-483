using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace _01___TaskClass_Sample_7
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() => {
                foreach (var item in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
            });

            Task write = Task.Run(() => {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s))
                    {
                        break;
                    }
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}
