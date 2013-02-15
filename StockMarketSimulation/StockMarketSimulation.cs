using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace StockMarketSimulation
{

    public class StockMarketSimulation
    {
        public DefaultValues defaultValues;
        public static int simDay = 1;
        public List<Stock> allStocks;
        public AgentManager am;
        public static Stopwatch stopwatch;
        public List<string> StopwatchTimes;
                
        public StockMarketSimulation()
        {
            DefaultValues defaultValues = new DefaultValues();
            stopwatch = new Stopwatch();
            StopwatchTimes = new List<string>();
           
        }

        public StockMarketSimulation(DefaultValues dv)
        {
            this.defaultValues = dv;
            StockMarketSimulation.simDay = 0;
            stopwatch = new Stopwatch();
            StopwatchTimes = new List<string>();
            
        }

        public void Start()
        {
            stopwatch.Reset();
            stopwatch.Start();
            StockMarketSimulation.simDay = 0;
            createStocks();
            am = new AgentManager(defaultValues);
            for (int i = 0; i < this.defaultValues.stopAtEpochNumber; i++)
            {
                am.letAgentsAct(allStocks);
                am.storeAgentsBudget();
                StockMarketSimulation.simDay++;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}.{2:00} (= {3} ticks)", ts.Minutes, ts.Seconds, ts.Milliseconds/10, ts.Ticks);
            StopwatchTimes.Add(elapsedTime);
        }

        //private double calculateNewPrice()
        //{
        //    return stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay);
        //}

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

