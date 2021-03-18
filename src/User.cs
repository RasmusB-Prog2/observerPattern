using System;

namespace Observer
{
    public class User: IObserver<string>, IDisposable
    {
        
        public IDisposable Unsubscriber { get; set; }
        
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(string value)
        {
            Console.WriteLine(value);
        }

        public void Dispose()
        {
            Unsubscriber?.Dispose();
        }
    }
}