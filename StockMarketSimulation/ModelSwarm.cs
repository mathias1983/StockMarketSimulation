using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{

    public class ModelSwarm
    {
        public List<Agent> AgentList = new List<Agent>();
        
        public ModelSwarm()
        {
            DefaultValues df = new DefaultValues();
            buildAgents(df);

            startAction();
        }

        public void buildAgents(DefaultValues variables)
        {
            for (int i = 0; i < variables.agentNumber; i++)
            {
                Agent a = new Agent(i, variables);
                AgentList.Add(a);
            }
        }

        public void startAction()
        {
            AgentManager am = new AgentManager(AgentList);
            am.act();
        }
    }

}

