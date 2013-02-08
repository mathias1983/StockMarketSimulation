using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public struct Order
    {
        public float OrderAgentPriceOfOrder;
        public int OrderAgentNumber;
        public int OrderAgentSizeOrder;
        public int simulationDay;
    }

    public class StockPriceBook
    {
        private Dictionary<int, List<Order>> Orders = new Dictionary<int, List<Order>>();
        
        private float lastPrice;
        private List<double> endOfDayPrices = new List<double>();
        
        public StockPriceBook()
        {

        }

        public double getMeanPrice(int range)
        {
            if (StockMarketSimulation.simDay == 0)
                return 1F;

            while (range > StockMarketSimulation.simDay)
            {
                range--;
            }

            double meanPrice = 0.0;
            for (int i = 0; i < StockMarketSimulation.simDay; i++)
            {
                meanPrice += this.getEndofDayPrice(StockMarketSimulation.simDay-1);
            }
            return (meanPrice ==0)? 1F : meanPrice / range;
        }

        public void agentActBeforeOpening()
        {

        }

        public void setLastPrice(float lastPrice)
        {
            this.lastPrice = lastPrice;
        }

        public float getLastPrice()
        {
            if (this.lastPrice == 0)
                return 1F;

            return this.lastPrice;
        }

        public float getLastMeanPrice(int range)
        {
            if (range > this.Orders.Count-1)
                return 1F;

            float LastMeanPrice = 1.0F;
            float LastPrices = 0F;
            for (int i = 1; i < range; i++)
            {
                LastPrices += this.Orders[i].ElementAt(this.Orders[i].Count).OrderAgentPriceOfOrder;
            }

            LastMeanPrice = LastPrices / range;

            return LastMeanPrice;
        }

        public float getPrice(int a)
        {
            if (Orders.Count > a && a >= 0)
                return this.Orders[StockMarketSimulation.simDay].ElementAt(this.Orders[StockMarketSimulation.simDay].Count).OrderAgentPriceOfOrder;
            else
                return 1F;

        }

        public void addDailyOrders(List<Order> dailyOrders)
        {
            double endOfDayPrice = 0.0;

            for (int i = 0; i < dailyOrders.Count; i++)
            {
                endOfDayPrice += dailyOrders.ElementAt(i).OrderAgentPriceOfOrder;
            }

            setEndOfDayPrice(endOfDayPrice);

            this.Orders.Add(StockMarketSimulation.simDay, dailyOrders);
        }


        public void setEndOfDayPrice(double price)
        {
            this.endOfDayPrices.Add(price);
        }

        public double getEndofDayPrice(int day)
        {
            if (this.endOfDayPrices.Count == 0 || day < 0)
                return 1;

            else 
                return this.endOfDayPrices.ElementAt(day);
        }
    }
}
