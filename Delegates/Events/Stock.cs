using System;

namespace Events
{
    class Stock
    {
        private string _symbol;
        private decimal price;
        public Stock(string symbol)
        {
            this._symbol = symbol;
        }

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        public decimal Price
        {
            get { return Price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }
    }

    public class PriceChangedEventArgs : EventArgs
    {
        public readonly decimal LastPrice;
        public readonly decimal NewPrice;

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }
}
