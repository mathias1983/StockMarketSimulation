﻿using System;
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
    public struct defaultValues
    {
        public int days;
        public int selectedStockNumber;
        public int numberOfStocks;
    }

    public partial class Form1 : Form
    {
        private StockManager stockManager;
        private defaultValues defaultValues;
        private DefaultValues agentValues;
        private StockMarketSimulation sms;
        public static Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            //create default values
            defaultValues = new defaultValues();
            defaultValues.days = 100;
            defaultValues.selectedStockNumber = 0;
            defaultValues.numberOfStocks = 5;


            //create stock manager
            stockManager = new StockManager();
            stockManager.loadRealDataStocks(defaultValues.numberOfStocks);

            agentValues = new DefaultValues();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloadComboBox();
        }

        private void reloadComboBox()
        {
            this.stockNameComboBox.Items.AddRange(stockManager.GetAllRealDataStockNames());
            this.stockNameComboBox.SelectedIndex = 0;
        }

        private void plotRealDataButton_Click(object sender, EventArgs e)
        {
            this.realDataChart.Series.Clear();
            int fromDays, toDays;
            try
            {
                fromDays = Int32.Parse(this.fromDaysTextBox.Text);
                toDays = Int32.Parse(this.toDaysTextBox.Text);
            }
            catch (Exception)
            {
                fromDays = defaultValues.days;
                toDays = defaultValues.days;
                this.fromDaysTextBox.Text = fromDays.ToString();
                this.toDaysTextBox.Text = toDays.ToString();
            }
            
            if (allStocksCheckBox.Checked)
            {
                for (int i = 0; i < stockManager.RealDataStocks.Count; i++)
                {
                    this.realDataChart.Series.Add(createSerieForChart(i, fromDays, toDays));
                }
            }
            else 
            {
                int selectedStockNumber = this.stockNameComboBox.SelectedIndex >= 0 ? this.stockNameComboBox.SelectedIndex : defaultValues.selectedStockNumber;
                this.realDataChart.Series.Add(createSerieForChart(selectedStockNumber, fromDays, toDays));
                this.stockNameComboBox.SelectedIndex = selectedStockNumber;
            }
            this.realDataChart.ChartAreas[0].AxisX.Title = "Day";
            this.realDataChart.ChartAreas[0].AxisY.Title = "Stock Price";
        }

        private Series createSerieForChart(int stockNumber, int fromDay, int toDay)
        {
            Stock stock = stockManager.RealDataStocks.ElementAt(stockNumber);
            //double[] prices = stock.GetPricesSince(days).ToArray();
            double[] prices = stock.GetPricesFromTo(fromDay, toDay).ToArray();
            Series serie = new Series();
            serie.ChartType = SeriesChartType.FastLine;
            serie.Name = stock.Name;
            serie.Color = getRandomColor();
            serie.XValueType = ChartValueType.Int32;
            serie.XValueMember = "Day";
            serie.YValueType = ChartValueType.Double;
            serie.YValueMembers = "Price";
            for (int i = 0; i < prices.Length; i++)
            {
                serie.Points.AddXY(i + 1, prices[i]);
            }
            return serie;
        }

        private Series createSerieForSimulatedDataChart(Stock stock, int length)
        {
            double[] prices = stock.GetPricesFromTo(0, length).ToArray();
            Series serie = new Series();
            serie.ChartType = SeriesChartType.FastLine;
            serie.Name = stock.Name;
            serie.Color = getRandomColor();
            serie.XValueType = ChartValueType.Int32;
            serie.XValueMember = "Day";
            serie.YValueType = ChartValueType.Double;
            serie.YValueMembers = "Price";
            for (int i = 0; i < prices.Length; i++)
            {
                serie.Points.AddXY(i + 1, prices[i]);
            }
            return serie;
        }

        public static Color getRandomColor()
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void loadStocksMenu_Click(object sender, EventArgs e)
        {
            StockLoadDialog dialog = new StockLoadDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) 
            {
                stockManager.loadRealDataStocks(dialog.NumOfStocks);
            }
            reloadComboBox();

        }

        private void agentPreferencesMenu_Click(object sender, EventArgs e)
        {
            AgentSettingsDialog dialog = new AgentSettingsDialog();
            DialogResult result = dialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                agentValues = new DefaultValues(dialog.EpochNumber, dialog.NumberOfTernaAgents, dialog.NumberOfRandomAgents, dialog.NumberOfRiskSeekingAgents, dialog.NumberOfRiskAvoidingAgents, dialog.NumberOfStocks, dialog.Budget, dialog.MaxOrders, dialog.StopLoss, (float) dialog.ProbOfImitatingMarket,
                                                (float)dialog.ProbOfLocalImitation, (float) dialog.AsymmetricBuySellProb, (float)dialog.ProbBeforeOpening,
                                                (float) dialog.MinCorrection, (float)dialog.MaxCorrection, (float)dialog.FloorPrice, (float)dialog.AgentProbActBelowFloorPrice, dialog.MeanPriceHistoryLength,
                                                dialog.LocalHistoryLength, (float) dialog.AgentProbAdoptStopLoss, (float)dialog.MaxLossRate);
            }
        }

        private void simulateBtn_Click(object sender, EventArgs e)
        {
            this.consoleTextbox.Text = "Simulating...";
            sms = new StockMarketSimulation(agentValues);
            sms.Start();
            this.simulationChart.Series.Clear();
            this.simulationChart.ResetAutoValues();
            foreach (Stock stock in sms.allStocks)
            {
                this.simulationChart.Series.Add(createSerieForSimulatedDataChart(stock, StockMarketSimulation.simDay - 1));
            }
            this.simulationChart.ChartAreas[0].AxisX.Title = "Day";
            this.simulationChart.ChartAreas[0].AxisY.Title = "Stock Price";
            this.consoleTextbox.Text = "Time Results: (Time needed for simulation in mm:ss.milliseconds)\n";
            foreach (string text in sms.StopwatchTimes)
            {
                this.consoleTextbox.Text += text + "\n";
            }
        }

        private void buySellHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sms == null || sms.am == null) return;

            BuySellHistory buySellHistory = new BuySellHistory(sms.allStocks, sms.am.AgentList);
            buySellHistory.ShowDialog();
        }

    }
}
