using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    interface IObserver
    {
        void Update();
    }

    interface IObservable
    {
        void AddObserver(IObserver o);
        void RemoveObserver(IObserver o);
        void NotifyObservers();
    }

    class FireGunObserver : IObservable
    {
        private List<IObserver> observers;
        public FireGunObserver()
        {
            observers = new List<IObserver>();
        }
        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update();
        }
    }
}
