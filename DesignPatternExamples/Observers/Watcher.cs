using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternExamples.Observers
{
    public class Watcher:IObserver<Subject>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(Subject value)
        {
            throw new NotImplementedException();
        }

        public void SeeSomething(String thatSomething)
        {
            Console.WriteLine("I saw: " + thatSomething);
        }
    }
}
