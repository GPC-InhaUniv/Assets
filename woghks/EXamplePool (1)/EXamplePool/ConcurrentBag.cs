using System;
using System.Collections.Concurrent;


namespace EXamplePool
{
    public class ConcurrentBag<T> where T : new()
    {
        internal void Add<T>(T item) where T : new()
        {
            throw new NotImplementedException();
        }

        internal bool TryTake<T>(out T item) where T : new()
        {
            throw new NotImplementedException();
        }
    }
}