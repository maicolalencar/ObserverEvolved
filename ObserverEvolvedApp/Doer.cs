using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDPApp
{
    public class Doer : ISubject
    {
        IList<IObserver> ObsList = new List<IObserver>();

        private string data = string.Empty;

        public void DoSomethingWith(string data)
        {
            this.data = data;
            //Console.WriteLine($"Doing Something with {data}");
            this.AfterDoSomethingWith(data);
        }

        public void DoMore(string appendData)
        {
            data += appendData;
            //Console.WriteLine($"Doing Something with {data}");
            this.AfterDoMore(data, appendData);
        }

        public void Attach(IObserver obs)
        {
            ObsList.Add(obs);
        }

        public void Dettach(IObserver obs)
        {
            ObsList.Remove(obs);
        }

        public void AfterDoSomethingWith(string data)
        {
            foreach(var itemObs in ObsList)
            {
                itemObs.AfterDoSomethingWith(this, data);
            }
        }

        public void AfterDoMore(string data, string appendData)
        {
            foreach (var itemObs in ObsList)
            {
                itemObs.AfterDoMore(this, data, appendData);
            }
        }
    }
}
