using System;

namespace ObserverDPApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Doer doer = new Doer();

            doer.Attach(new UserInterface());
            doer.Attach(new Logger());

            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
            
            Console.WriteLine("fim");
            Console.ReadKey();
        }
    }
}
