using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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
            calculateChart(0);
        }

        private void calculateTable()
        {
            this.tableView.Columns.Add("Agent Number", "Agent Number");
            this.tableView.Columns.Add("Agent Type", "Agent Type");
            this.tableView.Columns.Add("Final Budget", "Final Budget");
            this.tableView.Columns.Add("Final Shares", "Final Shares (StockNumber:amount)");
            this.tableView.Columns.Add("Value of Shares", "Value of Shares");
            this.tableView.Columns.Add("Total", "Total");
            string type = "intelligent";
            string shares = "";
            double valueOfShares = 0F;
            Dictionary<int, int> inventory;
            foreach (Agent agent in Agents)
            {
                shares = "";
                if (agent.GetType() == typeof(RandomAgent)) type = "random";
                else if (agent.GetType() == typeof(TernaAgent)) type = "terna";
                inventory = agent.getStockInventory();
                for (int i = 0; i < inventory.Count; i++)
                {
                    shares += i.ToString() + ":" + inventory[i].ToString() + " | ";
                }
                valueOfShares = calculateValueOfInventory(inventory);
                this.tableView.Rows.Add(agent.getAgentNumber(), type, Math.Round(agent.getBudget(), 2), shares, Math.Round(valueOfShares, 2), Math.Round(agent.getBudget()+valueOfShares, 2));
            }
        }

        private void calculateChart(int agentNumber)
        {
            this.agentMoneyChart.Series.Clear();
            this.agentMoneyChart.ResetAutoValues();
            this.agentMoneyChart.Series.Add(createSerieForAgentBudget(Agents.ElementAt(agentNumber)));
            this.agentMoneyChart.ChartAreas[0].AxisX.Title = "Day";
            this.agentMoneyChart.ChartAreas[0].AxisY.Title = "Money";

        }

        public double calculateValueOfInventory(Dictionary<int, int> inventory)
        {
            double sum = 0F;
            for (int i = 0; i < this.Stocks.Count; i++)
            {
                sum += inventory[i] * Stocks.ElementAt(i).stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay-1);
            }
            return sum;
        }

        private Series createSerieForAgentBudget(Agent agent)
        {
            float[] money = agent.getBudgetHistory().ToArray();
            Series serie = new Series();
            serie.ChartType = SeriesChartType.Column;
            string type = "intelligent";
            if (typeof(TernaAgent) == agent.GetType()) type = "terna";
            else if (typeof(RandomAgent) == agent.GetType()) type = "random";
            serie.Name = agent.getAgentNumber().ToString() + "("+type+")";
            serie.Color = Form1.getRandomColor();
            serie.XValueType = ChartValueType.Int32;
            serie.XValueMember = "Day";
            serie.YValueType = ChartValueType.Double;
            serie.YValueMembers = "Money";
            for (int i = 0; i < money.Length; i++)
            {
                serie.Points.AddXY(i+1, money[i]);
            }
            return serie;
        }

        private void tableView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            calculateChart(Convert.ToInt32(this.tableView.CurrentRow.Cells[0].Value));
        }
    }
}
