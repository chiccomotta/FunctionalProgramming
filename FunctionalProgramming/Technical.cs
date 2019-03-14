using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace FunctionalProgramming
{
    public class Technical
    {
        public decimal Value { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }


    public class GapsFinder
    {
        private static List<List<Technical>> allSamesList = new List<List<Technical>>();

        public static void findGaps()
        {
            var source = new List<Technical>
            {
                new Technical()
                {
                    Value = 25.0M,
                    StartDate = new DateTime(2018, 01, 01),
                    EndDate = new DateTime(2018, 02, 28)
                },
                new Technical()
                {
                    Value = 25.0M,
                    StartDate = new DateTime(2018, 03, 01),
                    EndDate = new DateTime(2018, 03, 31)
                },
                new Technical()
                {
                    Value = 10.0M,
                    StartDate = new DateTime(2018, 04, 01),
                    EndDate = new DateTime(2018, 04, 30)
                },
                new Technical()
                {
                    Value = 25.0M,
                    StartDate = new DateTime(2018, 05, 01),
                    EndDate = new DateTime(2018, 05, 30),
                },
                new Technical()
                {
                    Value = 10.0M,
                    StartDate = new DateTime(2018, 06, 01),
                    EndDate = new DateTime(2018, 06, 30),
                },
                new Technical()
                {
                    Value = 10.0M,
                    StartDate = new DateTime(2018, 07, 01),
                    EndDate = null
                }
            };
            
            source = source.OrderBy(i => i.StartDate).ToList();
            recursion(source.First(), source);

            Debug.Write(allSamesList.Count);
        }

        private static void recursion(Technical current, List<Technical> source)
        {
            if (current == null)
                return;

            var firstValue = current.Value;
            var remaining = source.SkipWhile(i => i.Value.Equals(firstValue)).ToList();
            var sameList = source.Except(remaining).ToList();

            allSamesList.Add(sameList);
            if(remaining.Any())
                recursion(remaining.First(), remaining);
        }
    }
}
