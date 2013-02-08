using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class AgentManager
    {
        private List<Agent> AgentList = new List<Agent>();
        private List<Order> dailyOrders = new List<Order>();
        private DefaultValues dv;

        public AgentManager(DefaultValues dv) {

            this.dv = dv;
            createAgents(dv);            
        }

        public void letAgentsAct()
        {
           
                for (int j = 0; j < AgentList.Count; j++)
                {
                    this.dailyOrders.Add(AgentList.ElementAt(j).act());
                }
                writeOrdersToStockPriceBook(this.dailyOrders);
                this.dailyOrders.Clear();
        }

        private void createAgents(DefaultValues dv)
        {
            for (int i = 0; i < dv.agentNumber; i++)
            {
                AgentList.Add(new Agent(i, dv));
            }

        }

        private void writeOrdersToStockPriceBook(List<Order> dailyOrders)
        {
            StockMarketSimulation.stockPriceBook.addDailyOrders(dailyOrders);
        }
    }
}
