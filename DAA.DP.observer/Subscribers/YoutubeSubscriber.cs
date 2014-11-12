namespace DAA.DP.observer.Subscribers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class YoutubeSubscriber : ISubscriber
    {
        public string youtube { get; private set; }

        public void Update(object sender, NewsEventArgs NewsComed)
        {
            youtube = NewsComed.Youtube;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Youtube: {0}", youtube);
        }
    }
}
