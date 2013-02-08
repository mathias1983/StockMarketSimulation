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
        
        private float lastPrice = 0F;
        private List<double> endOfDayPrices = new List<double>();
        public static int day = 0;

        public StockPriceBook()
        {

        }

        public float getMeanPrice(int range)
        {
            while (range >= this.Orders.Count)
            {
                range--;
            }

            float meanPrice = 0F;
            for (int i = Orders.Count; i < Orders.Count - range; i--)
            {
                meanPrice += this.getEndOfDayPrice(i);
            }
            return meanPrice / range;
        }

        private float getEndOfDayPrice(int day)
        {
            float dailyPrice = 0F;
            int counter = 0;

            foreach (var Order in this.Orders[day])
            {
                if (Order.simulationDay == day)
                {
                    dailyPrice += Order.OrderAgentPriceOfOrder;
                    counter++;
                }
            }

            return dailyPrice / counter;
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
            if (Orders.Count == 0)
                return 1F;
            else
                return lastPrice;
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

        private void setEndOfDayPrice(double price)
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
        public int getNumberOfOrders()
        {

            return this.Orders.Count;
        }
    }
}
