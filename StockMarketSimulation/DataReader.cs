using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace StockMarketSimulation
{
    class DataReader
    {
        public List<Stock> ReadInStocksFromFile(string path, int numberOfStocks = 0)
        {
            List<Stock> stocks = new List<Stock>();
            string[] lines = System.IO.File.ReadAllLines(path);
            Stock currentStock = new Stock(lines[0].Substring(1));
            for (int i = 1; i < lines.Length; i++)
            {
                if (lines[i].Contains('#'))
                {
                    if (currentStock != null) 
                    {
                        stocks.Add(currentStock);
                        if (numberOfStocks > 0 && stocks.Count >= numberOfStocks)
                        {
                            return stocks; 
                        }
                    }

                    currentStock = new Stock(lines[i].Substring(1));
                }
                else 
                {
                    currentStock.AddPrice(double.Parse(lines[i], CultureInfo.GetCultureInfo("en-US")));
                }
                
            }
            
            return stocks;
        }
    }
}
