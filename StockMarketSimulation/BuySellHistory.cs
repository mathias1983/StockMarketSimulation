using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockMarketSimulation
{
    public partial class BuySellHistory : Form
    {
        public List<Stock> Stocks;
        public List<Agent> Agents;
        public BuySellHistory(List<Stock> stocks, List<Agent> agents)
        {
            this.Stocks = stocks;
            this.Agents = agents;
            InitializeComponent();
            calculateTable();
        }

        private void calculateTable()
        {
            this.tableView.Columns.Add("Agent", "Agent");
            this.tableView.Columns.Add("Budget", "Budget");

            foreach (Agent agent in Agents)
            {
                this.tableView.Rows.Add(agent.number, agent.budget);
            }
        }
    }
}
