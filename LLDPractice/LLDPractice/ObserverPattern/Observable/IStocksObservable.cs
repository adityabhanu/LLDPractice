using LLDPractice.ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ObserverPattern.Observable
{
    public interface IStocksObservable
    {
        public void add(INotificationAlertObserver obj);
        public void remove(INotificationAlertObserver obj);
        public void notifySubscribers();
        public void setCount(int stockAdded);
        public int getCount();
    }
}
