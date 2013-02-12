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
            for (int i = 0; i < range; i++)
            {
                meanPrice += this.getEndofDayPrice(StockMarketSimulation.simDay - 1 - i);
            }
            return (meanPrice == 0) ? 1F : meanPrice / range;
        }

        // set the last executed price

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

        // get the mean price of a day out of a specific range of days

        public float getLastMeanPrice(int range)
        {
            if (range > this.Orders.Count - 1)
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

        public void addDailyOrders(List<Order> dailyOrders)
        {
            double endOfDayPrice = 0.0;

            for (int i = 0; i < dailyOrders.Count; i++)
            {
                endOfDayPrice += (dailyOrders.ElementAt(i).OrderAgentPriceOfOrder <= 0) ? dailyOrders.ElementAt(i).OrderAgentPriceOfOrder * -1 : dailyOrders.ElementAt(i).OrderAgentPriceOfOrder;
            }

            setEndOfDayPrice(endOfDayPrice/dailyOrders.Count);
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

        public int getLocalHistory(int range)
        {
            List<Order> dailyOrders = new List<Order>();

            if (this.Orders.Count <= 0)
                return 1;
            else 
                dailyOrders = this.Orders.ElementAt(StockMarketSimulation.simDay-1).Value;

            while (range > dailyOrders.Count)
            {
                range--;
            }
            
            int decision = 0;
            
            for (int i = 1; i < range; i++)
            {
                if (dailyOrders.ElementAt(range - i).OrderAgentPriceOfOrder <= 0)
                    decision--;
                else
                    decision++;
            }

            return decision;
        }
    }
}
