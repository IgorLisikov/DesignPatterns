using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class StockListView : IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            foreach (var stock in stocks)
                Console.WriteLine(stock);
        }

        public void Update()
        {
            Console.WriteLine("Refreshing StockListView:");
            Show();
        }
    }
}
