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
            st.PriceChanged += (new Program()).PriceChangedHandle;
            st.Price = 10;
            st.Price = 15;
            Console.ReadLine();
        }

        public void PriceChangedHandle(decimal oldPrice, decimal price)
        {
            Console.WriteLine("Price changed from {0} to {1} !", oldPrice, price);
        }
    }
}
