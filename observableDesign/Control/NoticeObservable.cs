using System;
using System.Collections.Generic;

namespace observerDesign
{
    public class NoticeObservable : Observable
    {
        List<Observer> list;

        public NoticeObservable()
        {
            list = new List<Observer>();
        }

        public void AddUser(Observer observer)
        {
            list.Add(observer);
        }

        public void Notify(string message)
        {
            list.ForEach(x => x.Notify(message));
        }

        public void RemoveUser(Observer observer)
        {
            list.Remove(observer);
        }
    }
}
