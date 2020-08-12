using System.Threading;

namespace LowLevelExercises.Core
{
    /// <summary>
    /// A simple class for reporting a specific value and obtaining an average.
    /// </summary>
    /// TODO: remove the locking and use <see cref="Interlocked"/> and <see cref="Volatile"/> to implement a lock-free implementation.
    public class AverageMetric
    {
        // TODO: this should not be needed, once you remove all the locks below
        readonly object sync = new object();

        int sum = 0;
        int count = 0;

        public void Report(int value)
        {
            Interlocked.Increment(ref count);
            Interlocked.Add(ref sum, value);
        }

        public double Average
        {
            get
            {
                var localSum = Volatile.Read(ref sum);
                var localCount = Volatile.Read(ref count);

                return Calculate(localCount, localSum);
            }
        }

        static double Calculate(in int count, in int sum)
        {
            // DO NOT change the way calculation is done.

            if (count == 0)
            {
                return double.NaN;
            }

            return (double)sum / count;
        }
    }
}
