using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Observers
{
    public class SubjectTracker : IObservable<Subject>
    {

        private List<IObserver<Subject>> watchers = new List<IObserver<Subject>>();


        public IDisposable Subscribe(IObserver<Subject> watcher)
        {
            if (!watchers.Contains(watcher))
                watchers.Add(watcher);
            return new Unsubscriber(watchers, watcher);
        }

        private class Unsubscriber : IDisposable
        {
            private List<IObserver<Subject>> _observers;
            private IObserver<Subject> _observer;

            public Unsubscriber(List<IObserver<Subject>> observers, IObserver<Subject> observer)
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
