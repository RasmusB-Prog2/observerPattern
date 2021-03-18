using System;
using System.Collections.Generic;

namespace Observer
{
    public class Channel : IObservable<string>
    {
        public Channel()
        {
            Value = String.Empty;
        }

        private IList<IObserver<string>> Observers { get; set; } = new List<IObserver<string>>();
        public IDisposable Subscribe(IObserver<string> observer)
        {
            Observers.Add(observer);
            return new Unsubscriber(Observers, observer);
        }
        
        public string Value { get; private set; }

        private void Update()
        {
            foreach (var observer in Observers)
            {
                observer.OnNext($"New Value is: { Value }");
            }
        }

        public void UpdateString(string newValue)
        {
            Value = newValue;
            Update();
        }
    }
}