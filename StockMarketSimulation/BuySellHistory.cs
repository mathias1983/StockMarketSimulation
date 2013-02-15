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
        }

        private void calculateTable()
        {
            this.tableView.Columns.Add("Agent Number", "Agent Number");
            this.tableView.Columns.Add("Agent Type", "Agent Type");
            this.tableView.Columns.Add("Final Budget", "Final Budget");

            foreach (Agent agent in Agents)
            {
                this.tableView.Rows.Add(agent.number, "normal", agent.budget);
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

        private Series createSerieForAgentBudget(Agent agent)
        {
            float[] money = agent.budgetHistory.ToArray();
            Series serie = new Series();
            serie.ChartType = SeriesChartType.FastLine;
            serie.Name = agent.number.ToString(); //TODO: hier noch typ vom agenten dazu
            serie.Color = Form1.getRandomColor();
            serie.XValueType = ChartValueType.Int32;
            serie.XValueMember = "Day";
            serie.YValueType = ChartValueType.Double;
            serie.YValueMembers = "Money";
            for (int i = 0; i < money.Length; i++)
            {
                serie.Points.AddXY(i + 1, money[i]);
            }
            return serie;
        }

        private void tableView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            calculateChart(e.RowIndex);
        }
    }
}
