namespace DAA.DP.observer.Subscribers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IObserver
    {
        void Update(string twitter, string youtube, string msdn);
        void RemoveFromPublisher();
    }
}
