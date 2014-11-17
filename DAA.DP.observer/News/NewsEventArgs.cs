namespace DAA.DP.observer.Subscribers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class NewsEventArgs
    {
        public string Twitter { get; private set; }
        public string Youtube { get; private set; }
        public string MSDN { get; private set; }

        public NewsEventArgs(string twitter, string youtube, string msdn)
        {
            Twitter = twitter;
            Youtube = youtube;
            MSDN = msdn;
        }
    }
}
