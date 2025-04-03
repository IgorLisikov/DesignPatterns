using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var statusBar = new StatusBar();
            var stockListView = new StockListView();

            var stock1 = new Stock("stock1", 10);
            var stock2 = new Stock("stock2", 20);
            var stock3 = new Stock("stock3", 30);

            statusBar.AddStock(stock1);
            statusBar.AddStock(stock2);

            stockListView.AddStock(stock1);
            stockListView.AddStock(stock2);
            stockListView.AddStock(stock3);

            stock2.SetPrice(21);
            stock3.SetPrice(9);



        }
    }
}
