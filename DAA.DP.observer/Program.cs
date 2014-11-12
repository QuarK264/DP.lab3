namespace DAA.DP.observer
{
    using DAA.DP.observer.News;
    using DAA.DP.observer.Subscribers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            var NewsAgregator = new NewsAgregator();
            var TwitterSubscriber = new TwitterSubscriber();
            var YoutubeSubscriber = new YoutubeSubscriber();
            var MSDNSubsriber = new MSDNSubscriber();

            NewsAgregator.NewsChanged += TwitterSubscriber.Update;
            NewsAgregator.NewsChanged += YoutubeSubscriber.Update;
            NewsAgregator.NewsChanged += MSDNSubsriber.Update;

            NewsAgregator.NewNewsAvaliable();
            Console.WriteLine();

            NewsAgregator.NewsChanged -= MSDNSubsriber.Update;
            NewsAgregator.NewNewsAvaliable();

            Console.ReadLine();
        }
    }
}
