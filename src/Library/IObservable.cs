using System;

namespace Observer
{
    public interface IObvservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyChanges();
    }
}