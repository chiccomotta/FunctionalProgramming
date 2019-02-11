using System;
using System.Linq;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    public static class MutableAndImmutable
    {
        public static void MutateState()
        {
            var nums = Enumerable.Range(-10000, 20001).Reverse().ToList();

            Action task1 = () =>
            {
                try
                {
                    Console.WriteLine(nums.Sum());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            };

            Action task2 = () =>
            {
                nums.Sort();
                Console.WriteLine(nums.Sum());
            };

            Parallel.Invoke(task1, task2);
        }

        public static void NotMutateState()
        {
            var nums = Enumerable.Range(-10000, 20001).Reverse().ToList();

            Action task1 = () => Console.WriteLine(nums.Sum());

            Action task3 = () =>
            {
                Console.WriteLine(nums.OrderBy(x => x).Sum());
            };

            Parallel.Invoke(task1, task3);
        }
    }
}
