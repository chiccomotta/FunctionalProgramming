using System;
using System.Threading;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
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
