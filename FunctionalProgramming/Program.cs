using System;
using System.Diagnostics;
using System.Threading;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string> func = () =>
            {
                string tmp = string.Empty;

                for (int k = 0; k < 1000; k++)
                {
                    for (int i = 0; i < 10000; i++)
                    {
                        tmp = i.ToString();
                    }
                }

                return tmp;
            };

            var (duration, result) = StopwatchWrapper.Time<string>(func);

            Console.WriteLine($"duration: {duration} - result: {result}");
            Console.ReadLine();
            return;

            ParallelizePureFunctions.ParallelizeOperations();

            while (true)
            {
                MutableAndImmutable.MutateState();
                MutableAndImmutable.NotMutateState();
                Thread.Sleep(500);
            }
        }
    }
}
