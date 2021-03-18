using System;
using System.Collections.Generic;
using System.Linq;

namespace Observer
{
    public class Unsubscriber : IDisposable
    {
        private readonly IList<IObserver<string>> _observers;
        private readonly IObserver<string> _observer;

        public Unsubscriber(IList<IObserver<string>> observers, IObserver<string> observer)
        {
            _observers = observers;
            _observer = observer;
        }
        
        public void Dispose()
        {
            if (_observer != null && _observers.Any(x => x == _observer))
            {
                _observers.Remove(_observer);
            }
        }
    }
}