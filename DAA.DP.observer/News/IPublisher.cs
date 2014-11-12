namespace DAA.DP.observer.News
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IPublisher
    {
        void RegisterObserver(Subscribers.IObserver observer);
        void RemoveObserver(Subscribers.IObserver observer);
        void NotifySubscribers();
    }
}
