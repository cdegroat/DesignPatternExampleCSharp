using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Observers
{
    public class Subject
    {
        private String currentAction;
        public void DoSomething(String thatSomething)
        {
            Console.WriteLine("The subject did: " + thatSomething);
            currentAction = thatSomething;
            foreach(var watcher in watchers)
            {
                //watcher.OnNext(this);
            }
        }

        public IDisposable Subscribe(IObserver<Watcher> watcher)
        {
            watchers.Add(watcher);
            return new Unsubscriber(watchers, watcher);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Watcher>> _observers;
            private IObserver<Watcher> _observer;

            public Unsubscriber(List<IObserver<Watcher>> observers, IObserver<Watcher> observer)
            {
                this._observers = observers;
                this._observer = observer;
            }

            public void Dispose()
            {
                if (_observer != null && _observers.Contains(_observer))
                    _observers.Remove(_observer);
            }
        }
    }
}
