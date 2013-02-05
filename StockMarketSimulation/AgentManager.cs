using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class AgentManager
    {
        public StockPriceBook stockPriceBook;
        private List<Agent> AgentList;

        public AgentManager(List<Agent> agents) {
            this.AgentList = agents;
            this.stockPriceBook = new StockPriceBook();
        }

        public void act() 
        {
            foreach (Agent agent in AgentList)
            {
                agent.act(this.stockPriceBook);
            }

            for (int i = 0; i < this.stockPriceBook.getNumberOfOrders(); i++)
            {
                Console.WriteLine("Agent-Number # " + this.stockPriceBook.getAllOrders().ElementAt(i).OrderAgentNumber);
                Console.WriteLine(this.stockPriceBook.getAllOrders().ElementAt(i).OrderAgentPriceOfOrder);
            }
        }
    }
}
