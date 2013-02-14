using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace StockMarketSimulation
{
    public partial class AgentSettingsDialog : Form
    {
        public CultureInfo info;
        public int EpochNumber
        { get { return Int32.Parse(epochNumberTextbox.Text); } }
        public int NumberOfStocks
        { get { return Int32.Parse(numOfStocksTextbox.Text); } }
        public int Budget
        { get { return Int32.Parse(budgetTextbox.Text); } }
        public int NumberOfAgents
        { get{ return Int32.Parse(numberOfAgentsTextBox.Text); } }
        public int MaxOrders
        { get{ return Int32.Parse(maxOrdersTextBox.Text); } }
        public int StopLoss
        { get{ return Int32.Parse(stopLossTextBox.Text); } }
        public double ProbOfImitatingMarket
        { get{ return double.Parse(probImitatingMarketTextbox.Text, info); } }
        public double ProbOfLocalImitation
        { get{ return double.Parse(probLocalImitationTextBox.Text, info); } }
        public double AsymmetricBuySellProb
        { get{ return double.Parse(asymmetricTextbox.Text, info); } }
        public double ProbBeforeOpening
        { get{ return double.Parse(probBeforeOpeningTextbox.Text, info); } }
        public double MinCorrection
        { get{ return double.Parse(minCorTextbox.Text, info); } }
        public double MaxCorrection
        { get{ return double.Parse(maxCorTextbox.Text, info); } }
        public double AgentProbActBelowFloorPrice
        { get{ return double.Parse(agentProbActBelowFloorPriceTextbox.Text, info); } }
        public double FloorPrice
        { get{ return double.Parse(floorPriceTextbox.Text, info); } }
        public int LocalHistoryLength
        { get{ return Int32.Parse(localHostoryLengthTextbox.Text); } }
        public int MeanPriceHistoryLength
        { get{ return Int32.Parse(meanPriceHistoryLengthTextbox.Text); } }
        public double MaxLossRate
        { get{ return double.Parse(maxLossRateTextBox.Text, info); } }
        public double AgentProbAdoptStopLoss
        { get{ return double.Parse(agentProbAdoptStopLossTextbox.Text, info); } }

        public AgentSettingsDialog()
        {
            info = new CultureInfo("en-US");
            InitializeComponent();
        }

    }
}