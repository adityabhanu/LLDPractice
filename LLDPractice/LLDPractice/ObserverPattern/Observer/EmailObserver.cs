using LLDPractice.ObserverPattern.Observable;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ObserverPattern.Observer
{
    public class EmailObserver : INotificationAlertObserver
    {
        public IStocksObservable stocksObservable;
        public string email;
        public EmailObserver(IStocksObservable _stocksObservable, string _email) {
            this.stocksObservable = _stocksObservable;
            this.email = _email;
        }
        public void update()
        {
            Console.WriteLine("Email sent successfully to email {0}", this.email);
        }
    }
}
