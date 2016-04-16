using System;

namespace Events
{
    class Program
    {
        static void Main()
        {
            Stock st = new Stock("Koza");
            st.Price = 10;
            st.PriceChanged += stock_PriceChanged;
            st.Price = 15;
            st.Price = 11;
            Console.ReadLine();
        }

        static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            if((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M) Console.WriteLine("Alert! 10% stock price increase! {0} to {1}", e.LastPrice, e.NewPrice);
            Console.WriteLine(sender.ToString());
        }
    }
}
