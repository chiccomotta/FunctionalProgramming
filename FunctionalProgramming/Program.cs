using System;
using System.Diagnostics;
using System.Threading;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            GapsFinder.findGaps();












            return;

            Person p1 = new Person() {Name = "Gianni", CostoAnnuo = 10000M};
            Person p2 = new Person() { Name = "Bruno", CostoAnnuo = 7540M };
            Person p3 = new Person() { Name = "Franco", CostoAnnuo = 10000M };

            // operator overload
            var costo = p1 + p2;
            Console.WriteLine($"Costo totale {costo}");

            // implicit cast operator
            decimal costoAnnuo = p1;
            Console.WriteLine($"Costo annuo {costoAnnuo}");

            // >  operator            
            Console.WriteLine($"Person1 > Person2 ? {p1 > p2}");
            
            // < operator            
            Console.WriteLine($"Person1 < Person2 ? {p1 < p2}");

            // >= operator            
            Console.WriteLine($"Person1 >= Person3 ? {p1 >= p3}");
            
            // Maybe
            var maybeHello = "hello".MaybeParseInt();
            Console.WriteLine(maybeHello.HasValue());

            var maybe10 = "10".MaybeParseInt();
            Console.WriteLine(maybe10.HasValue());
            Console.WriteLine(maybe10.Value);

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
