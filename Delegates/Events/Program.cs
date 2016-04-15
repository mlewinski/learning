using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Stock st = new Stock("Koza");
            st.Price = 10;
            st.PriceChanged += stock_PriceChanged;
            st.Price = 10;
            st.Price = 15;
            st.Price = 11;
            Console.ReadLine();
        }

        static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M) Console.WriteLine("Alert! 10% stock price increase! {0} to {1}", e.LastPrice, e.NewPrice);
        }
    }
}
