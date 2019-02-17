using System;
using System.Threading;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelizePureFunctions.ParallelizeOperations();

            Console.ReadLine();
            return;

            while (true)            
            {
                MutableAndImmutable.MutateState();
                MutableAndImmutable.NotMutateState();
                Thread.Sleep(500);
            }
        }
    }
}
