using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Stock : Observable
    {
        private string symbol;
        private float price;

        public Stock(string symbol, float price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float price)
        {
            this.price = price;
            NotifyObservers();
        }

        public override string ToString()
        {
            return "Stock{" +
                    "symbol='" + symbol + '\'' +
                    ", price=" + price +
                    '}';
        }
    }
}
