namespace DAA.DP.observer.Subscribers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TwitterSubscriber : ISubscriber
    {
        public string twitter { get; private set; }

        public void Update(object sender, NewsEventArgs NewsComed)
        {
            twitter = NewsComed.Twitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Twitter: {0}", twitter);
        }
    }
}
