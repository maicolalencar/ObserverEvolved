using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class Logger : IObserver
    {
        public void AfterDoSomethingWith(ISubject sender, string data)
        {
            Console.WriteLine($"Writing down {data.ToUpper()}");
        }

        public void AfterDoMore(ISubject sender, string completeData, string appendData)
        {
            Console.WriteLine($"Writing down append {appendData.ToUpper()}");
        }
    }
}
