using LLDPractice.ObserverPattern.Observable;
using LLDPractice.ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDPractice.ObserverPattern
{
    public class Store
    {
        public static void main()
        {
            IStocksObservable iphoneObservable = new ApplePhoneObservable();

            INotificationAlertObserver obs1 = new EmailObserver(iphoneObservable, "abc@gmail.com");
            INotificationAlertObserver obs2 = new EmailObserver(iphoneObservable, "xyz@gmail.com");
            INotificationAlertObserver obs3 = new SmsObserver(iphoneObservable, "75200983333");

            iphoneObservable.add(obs1);
            iphoneObservable.add(obs2);
            iphoneObservable.add(obs3);

            iphoneObservable.setCount(1);

            iphoneObservable.setCount(0);

            iphoneObservable.setCount(12);
        }
    }
}
