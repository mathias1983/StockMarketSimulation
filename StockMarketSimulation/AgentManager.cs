using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class AgentManager
    {
        public StockPriceBook spb;
        private List<Agent> AgentList;

        public AgentManager(List<Agent> agents) {
            this.AgentList = agents;
            this.spb = new StockPriceBook();
        }

        public void act() 
        {
            foreach (Agent agent in AgentList)
            {
                agent.act(this.spb);
            }

            for (int i = 0; i < this.spb.getNumberOfOrders(); i++)
            {
                Console.WriteLine("Agent-Number # " + this.spb.getAllOrders().ElementAt(i).OrderAgentNumber);
                Console.WriteLine(this.spb.getAllOrders().ElementAt(i).OrderAgentPriceOfOrder);
            }
        }
    }
}
