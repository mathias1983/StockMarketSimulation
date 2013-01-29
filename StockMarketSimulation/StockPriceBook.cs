using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public struct SellOrders
    {
        public int OrderAgentNumber;
        public float OrderAgentPriceOfOrder;
        public int OrderAgentSizeOrder;
    }

    public struct BuyOrders
    {
        public int OrderAgentNumber;
        public float OrderAgentPriceOfOrder;
        public int OrderAgentSizeOrder;
    }

    public struct Order
    {
        public int OrderAgentNumber;
        public float OrderAgentPriceOfOrder;
        public int OrderAgentSizeOrder;
        public bool bs;
    }

    public class StockPriceBook
    {
        private List<Order> Orders = new List<Order>();

        public StockPriceBook()
        {
           
        }

        public void agentActBeforeOpening()
        {
 
        }
        
        public float getLastPrice()
        {
            if (Orders.Count == 0)
                return 1F;
            else
                return this.Orders.ElementAt(Orders.Count-1).OrderAgentPriceOfOrder;
        }

        public float getLastMeanPrice(int range)
        {
            float LastMeanPrice = 1.0F;
            float LastPrices = 0F;
            for (int i = 1; i < range+1; i++)
            {
                LastPrices += this.Orders.ElementAt(Orders.Count - i).OrderAgentPriceOfOrder;
            }

            LastMeanPrice = LastPrices / range;

            return LastMeanPrice;
        }

        public int getSize()
        {
            return this.Orders.Count;
        }

        public float getPrice(int a)
        {
            return this.Orders.ElementAt(a).OrderAgentPriceOfOrder;
        }

        public void addOrder(Order order)
        {
            this.Orders.Add(order);
        }

        public List<Order> getAllOrders()
        {
            return this.Orders;
        }

        public int getNumberOfOrders()
        {
            return this.Orders.Count;
        }

    }
}
