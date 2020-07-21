using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace AwaitableExercises.Core
{
    public static class BoolExtensions
    {
        //public static TaskAwaiter<bool> GetAwaiter(this bool value)
        //    => Task.FromResult(value).GetAwaiter();
        public static BoolAwaiter GetAwaiter(this bool value)
            => new BoolAwaiter(value);
    }

    public class BoolAwaiter : INotifyCompletion
    {
        private readonly bool _value;

        public bool GetResult() => _value;
        public bool IsCompleted => true;

        public BoolAwaiter(bool value)
        {
            _value = value;
        }

        public BoolAwaiter GetAwaiter() => this;

        public void OnCompleted(Action continuation)
        {
            continuation();
        }
    }
}
