using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Dettach(IObserver observer);
        void AfterDoSomethingWith(string data);
        void AfterDoMore(string completeData, string appendData);

    }
}
