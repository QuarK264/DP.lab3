namespace DAA.DP.observer.News
{
    using DAA.DP.observer.Subscribers;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs NewsComed);

    public class NewsAgregator
    {
        private Random random { get; set; }

        public NewsAgregator()
        {
            random = new Random();
        }

        public event NewsChangedEventHandler NewsChanged;

        public string GetTwitterNews()
        {
            var news = new List<string>
                           {
                               "Новость из Twitter номер 1",
                               "Новость из Twitter номер 2",
                               "Новость из Twitter номер 3"
                           };

            return news[random.Next(3)];
        }

        public string GetYoutubeNews()
        {
            var news = new List<string>
                           {
                               "Новость из Youtube номер 1",
                               "Новость из Youtube номер 2",
                               "Новость из Youtube номер 3"
                           };

            return news[random.Next(3)];
        }

        public string GetMSDNNews()
        {
            var news = new List<string>
                           {
                               "Новость из MSDN номер 1",
                               "Новость из MSDN номер 2",
                               "Новость из MSDN номер 3"
                           };

            return news[random.Next(3)];
        }

        public void NewNewsAvaliable()
        {
            string twitter = GetTwitterNews();
            string youtube = GetYoutubeNews();
            string msdn = GetMSDNNews();

            if (NewsChanged != null)
            {
                NewsChanged(this, new NewsEventArgs(twitter, youtube, msdn));
            }
        }
    }
}
