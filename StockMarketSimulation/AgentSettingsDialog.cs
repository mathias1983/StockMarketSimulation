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
    public partial class AgentSettingsDialog : Form
    {
        public int EpochNumber
        { get { return Int32.Parse(epochNumberTextbox.Text); } }
        public int NumberOfAgents
        { get{ return Int32.Parse(numberOfAgentsTextBox.Text); } }
        public int MaxOrders
        { get{ return Int32.Parse(maxOrdersTextBox.Text); } }
        public int StopLoss
        { get{ return Int32.Parse(stopLossTextBox.Text); } }
        public double ProbOfImitatingMarket
        { get{ return double.Parse(probImitatingMarketTextbox.Text); } }
        public double ProbOfLocalImitation
        { get{ return double.Parse(probLocalImitationTextBox.Text); } }
        public double AsymmetricBuySellProb
        { get{ return double.Parse(asymmetricTextbox.Text); } }
        public double ProbBeforeOpening
        { get{ return double.Parse(probBeforeOpeningTextbox.Text); } }
        public double MinCorrection
        { get{ return double.Parse(minCorTextbox.Text); } }
        public double MaxCorrection
        { get{ return double.Parse(maxCorTextbox.Text); } }
        public double AgentProbActBelowFloorPrice
        { get{ return double.Parse(agentProbActBelowFloorPriceTextbox.Text); } }
        public double FloorPrice
        { get{ return double.Parse(floorPriceTextbox.Text); } }
        public int LocalHistoryLength
        { get{ return Int32.Parse(localHostoryLengthTextbox.Text); } }
        public int MeanPriceHistoryLength
        { get{ return Int32.Parse(meanPriceHistoryLengthTextbox.Text); } }
        public double MaxLossRate
        { get{ return double.Parse(maxLossRateTextBox.Text); } }
        public double AgentProbAdoptStopLoss
        { get{ return double.Parse(agentProbAdoptStopLossTextbox.Text); } }

        public AgentSettingsDialog()
        {
            InitializeComponent();
        }
    }
}