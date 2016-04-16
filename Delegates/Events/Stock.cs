using System;

namespace Events
{
    class Stock
    {
        public string Symbol;
        private decimal _price;
        public Stock(string symbol)
        {
            Symbol = symbol;
        }

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price == value) return;
                decimal oldPrice = _price;
                _price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, _price));
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
