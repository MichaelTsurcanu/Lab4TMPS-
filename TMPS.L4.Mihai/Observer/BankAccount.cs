using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMPS.L4.Mihai.Observer
{
    class BankAccount : ISubject
    {
        private double balance;
        private List<IObserver> observers;

        public BankAccount()
        {
            observers = new List<IObserver>();
        }

        public double Balance
        {
            get { return balance; }
            set
            {
                balance = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(balance);
            }
        }
    }
}
