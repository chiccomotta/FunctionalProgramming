using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FunctionalProgramming
{
    public class StopwatchWrapper
    {
        public static (double elapsedTime, T result) Time<T>(Func<T> f)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            T t = f();

            sw.Stop();
            return (sw.ElapsedMilliseconds, t);
        }
    }
}