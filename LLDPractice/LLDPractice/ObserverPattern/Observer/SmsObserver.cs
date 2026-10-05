using LLDPractice.ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ObserverPattern.Observer
{
    public class SmsObserver : INotificationAlertObserver
    {
        public string mobile;
        public IStocksObservable stocksObservable;

        public SmsObserver(IStocksObservable _stocksObservable,  string _mobile)
        {
            this.stocksObservable = _stocksObservable;
            this.mobile = _mobile;
        }

        public void update()
        {
            Console.WriteLine("Sms sent succesffuly to {0}", this.mobile);
        }
    }
}
