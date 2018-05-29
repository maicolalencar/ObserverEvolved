using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class UserInterface : IObserver
    {
        public void AfterDoSomethingWith(ISubject sender, string data)
        {
            Console.WriteLine($"Hey user look at {data.ToUpper()}");
        }

        public void AfterDoMore(ISubject sender, string completeData, string appendData)
        {
            //Console.WriteLine($"Writing down append {completeData.ToUpper() + appendData.ToUpper()}");
        }

    }
}
