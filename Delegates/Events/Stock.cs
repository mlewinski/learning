using System;

namespace Events
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    class Stock
    {
        private string symbol;
        private decimal price;

        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        public event PriceChangedHandler PriceChanged;

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                PriceChanged?.Invoke(oldPrice, price);
            }
        }
    }
}
