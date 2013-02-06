using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{

    public class ModelSwarm
    {
        public List<Agent> AgentList = new List<Agent>();
        public DefaultValues defaultValues;
        public Stock currentStock;
        public ModelSwarm()
        {
            DefaultValues defaultValues = new DefaultValues();
            buildAgents(defaultValues);
            startAction();
        }

        public ModelSwarm(DefaultValues dv)
        {
            this.defaultValues = dv;
        }

        public void Start()
        {
            currentStock = new Stock("1");
            buildAgents(this.defaultValues);
            startAction();
        }

        private void buildAgents(DefaultValues variables)
        {
            for (int i = 0; i < variables.agentNumber; i++)
            {
                Agent a = new Agent(i, variables);
                AgentList.Add(a);
            }
        }

        private void startAction()
        {
            AgentManager am = new AgentManager(AgentList);
            for (int i = 0; i < defaultValues.stopAtEpochNumber; i++)
            {
                am.act();
                currentStock.AddPrice(calculateNewPrice(am.stockPriceBook));
            }
        }

        private double calculateNewPrice(StockPriceBook stockPriceBook)
        {
            double price = currentStock.CurrentPrice;
            for (int i = 0; i < stockPriceBook.getNumberOfOrders(); i++)
            {
                price += (double) stockPriceBook.getAllOrders().ElementAt(i).OrderAgentPriceOfOrder;
            }
            return price;
        }
    }

}

