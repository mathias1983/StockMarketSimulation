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

        public void letAgentsAct(List<Stock> allStocks)
        {
            foreach (Stock currentStock in allStocks)
            {
                for (int j = 0; j < AgentList.Count; j++)
                {
                    Order orderBeforeOpening = AgentList.ElementAt(j).actBeforeOpening();
                    Order orderAtMarket = AgentList.ElementAt(j).act();
                    if (orderBeforeOpening.OrderAgentPriceOfOrder != 0 && orderBeforeOpening.OrderAgentSizeOrder > 0) this.dailyOrders.Add(orderBeforeOpening);
                    if (orderAtMarket.OrderAgentPriceOfOrder != 0 && orderBeforeOpening.OrderAgentSizeOrder > 0) this.dailyOrders.Add(orderAtMarket);

                }
                currentStock.stockPriceBook.addDailyOrders(dailyOrders);
                currentStock.AddPrice(currentStock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay));
                this.dailyOrders.Clear();
            }
        }

        private void createAgents(DefaultValues dv)
        {
            for (int i = 0; i < dv.agentNumber; i++)
            {
                AgentList.Add(new Agent(i, dv));
            }

        }
    }
}
