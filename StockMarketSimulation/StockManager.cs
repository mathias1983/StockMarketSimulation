using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    class StockManager
    {
        private List<Stock> realDataStocks;
        public List<Stock> RealDataStocks
        {
            get { return realDataStocks; }
        }

        private List<Stock> simulatedStocks;
        public List<Stock> SimulatedStocks
        {
            get { return simulatedStocks; }
        }


        public StockManager()
        {
            
        }

        public void loadRealDataStocks(int numOfStocks)
        {
            realDataStocks = readInRealDataStocks(numOfStocks);
        }

        private List<Stock> readInRealDataStocks(int numOfStocks)
        {
            List<Stock> stocks = new List<Stock>();
            DataReader dataReader = new DataReader();
            stocks = dataReader.ReadInStocksFromFile("stockPrices.dat", numOfStocks);
            return stocks;
        }

        public string[] GetAllRealDataStockNames()
        {
            string[] allNames = new string[realDataStocks.Count];
            for (int i = 0; i < realDataStocks.Count; i++)
            {
                allNames[i] = realDataStocks.ElementAt(i).Name; 
            }
            return allNames;
        }
    }
}
