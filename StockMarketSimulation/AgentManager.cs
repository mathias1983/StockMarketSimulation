using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class AgentManager
    {
        public List<Agent> AgentList = new List<Agent>();
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
                    Order orderBeforeOpening = AgentList.ElementAt(j).actBeforeOpening(currentStock);
                    Order orderAtMarket = AgentList.ElementAt(j).act(currentStock);
                    if (orderBeforeOpening.OrderAgentPriceOfOrder != 0 && orderBeforeOpening.OrderAgentSizeOrder > 0) this.dailyOrders.Add(orderBeforeOpening);
                    if (orderAtMarket.OrderAgentPriceOfOrder != 0 && orderBeforeOpening.OrderAgentSizeOrder > 0) this.dailyOrders.Add(orderAtMarket);

                }
                currentStock.stockPriceBook.addDailyOrders(dailyOrders);
                currentStock.AddPrice(currentStock.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay));
                this.dailyOrders.Clear();
            }
        }
        public void storeAgentsBudget()
        {
            foreach (Agent agent in AgentList)
            {
                agent.budgetHistory.Add(agent.budget);
            }
        }

        private void createAgents(DefaultValues dv)
        {
            int agentNumber = dv.ternaAgentNumber + dv.randomAgentNumber + dv.intelligentAgentNumber;
            for (int i = 0; i < agentNumber; i++)
            {
                if (i < dv.randomAgentNumber) AgentList.Add(new RandomAgent(i, dv));
                else if (i < dv.randomAgentNumber+dv.ternaAgentNumber) AgentList.Add(new TernaAgent(i, dv));
                //else AgentList.Add(new IntelligentAgent(i, dv));
            }

        }
    }
}
