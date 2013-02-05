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
            am.act();
        }
    }

}

