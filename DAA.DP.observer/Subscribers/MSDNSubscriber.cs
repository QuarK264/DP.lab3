using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAA.DP.observer.Subscribers
{
    class MSDNSubscriber : ISubscriber
    {
        public string msdn { get; private set; }

        public void Update(object sender, NewsEventArgs NewsComed)
        {
            msdn = NewsComed.MSDN;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("MSDN: {0}", msdn);
        }
    }
}
