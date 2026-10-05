using LLDPractice.ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ObserverPattern.Observable
{
    public class ApplePhoneObservable : IStocksObservable
    {
        public List<INotificationAlertObserver> notificationAlertObservers = new List<INotificationAlertObserver>();

        public int stocks = 0;

        public void add(INotificationAlertObserver notificationAlertObserver)
        {
            notificationAlertObservers.Add(notificationAlertObserver);
        }

        public void remove(INotificationAlertObserver notificationAlertObserver)
        {
            notificationAlertObservers.Remove(notificationAlertObserver);
        }

        public void notifySubscribers()
        {
            foreach (INotificationAlertObserver notificationObserver in notificationAlertObservers)
            {
                notificationObserver.update();
            }
        }

        public void setCount(int count)
        {
            if(this.stocks == 0)
            {
                notifySubscribers();
            }
            this.stocks = count;
        }

        public int getCount()
        {
            return this.stocks;
        }

    }
}
