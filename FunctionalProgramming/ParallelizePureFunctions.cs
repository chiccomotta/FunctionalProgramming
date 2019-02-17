using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    public static class StringExt
    {
        public static string ToSentenceCase(this string s) =>
            s.ToUpper()[0] + s.ToLower().Substring(1);
    }

    public class ParallelizePureFunctions
    {
        public static void ParallelizeOperations()
        {
            var list = new List<string> {"coffee", "bananas", "dates"};
            var list2 = list.AsParallel().Select(StringExt.ToSentenceCase).ToList();

            list2.ForEach(Console.WriteLine);
        }
    }
}
