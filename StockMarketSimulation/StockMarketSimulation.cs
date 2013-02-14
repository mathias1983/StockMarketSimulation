using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{

    public class StockMarketSimulation
    {
        public DefaultValues defaultValues;
        public static StockPriceBook stockPriceBook;
        public static int simDay = 1;
        public List<Stock> allStocks;
                
        public StockMarketSimulation()
        {
            DefaultValues defaultValues = new DefaultValues();
           
        }

        public StockMarketSimulation(DefaultValues dv)
        {
            this.defaultValues = dv;
            stockPriceBook = new StockPriceBook();
            StockMarketSimulation.simDay = 0;
            
        }

        public void Start()
        {
            createStocks();
            AgentManager am = new AgentManager(defaultValues);
            for (int i = 0; i < this.defaultValues.stopAtEpochNumber; i++)
            {
                am.letAgentsAct(allStocks);
                StockMarketSimulation.simDay++;
            }
        }

        private double calculateNewPrice()
        {
            return stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay);
        }

        private void createStocks()
        {
            allStocks = new List<Stock>();
            for (int i = 0; i < defaultValues.stockNumber; i++)
            { 
                Stock stock = new Stock(i.ToString());
                allStocks.Add(stock);
            }
        }
    }

}

