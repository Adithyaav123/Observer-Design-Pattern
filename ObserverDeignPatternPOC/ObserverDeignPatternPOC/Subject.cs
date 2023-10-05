using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDeignPatternPOC
{
    internal class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string message;

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(message);
            }
        }
        public void SetMessage(string message)
        {
            this.message = message;
            Console.WriteLine($"Message set to: {message}");
            Notify();
        }
    }
}
