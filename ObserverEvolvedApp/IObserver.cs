using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public interface IObserver
    {
        void AfterDoSomethingWith(ISubject sender, string data);
        void AfterDoMore(ISubject sender, string completeData, string appendData);
        
    }
}
