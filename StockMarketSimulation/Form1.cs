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
        public Form1()
        {
            InitializeComponent();

            //create default values
            defaultValues = new defaultValues();
            defaultValues.days = 1000;
            defaultValues.selectedStockNumber = 0;
            defaultValues.numberOfStocks = 100;


            //create stock manager
            stockManager = new StockManager();
            stockManager.loadRealDataStocks(defaultValues.numberOfStocks);
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
            int days;
            try
            {
                days = Int32.Parse(this.sinceDaysTextBox.Text);
            }
            catch (Exception)
            {
                days = defaultValues.days;
                this.sinceDaysTextBox.Text = days.ToString();
            }
            
            if (allStocksCheckBox.Checked)
            {
                for (int i = 0; i < stockManager.RealDataStocks.Count; i++)
                {
                    this.realDataChart.Series.Add(createSerieForChart(i, days, getRandomColor()));
                }
            }
            else 
            {
                int selectedStockNumber = this.stockNameComboBox.SelectedIndex >= 0 ? this.stockNameComboBox.SelectedIndex : defaultValues.selectedStockNumber;
                this.realDataChart.Series.Add(createSerieForChart(selectedStockNumber, days, getRandomColor()));
                this.stockNameComboBox.SelectedIndex = selectedStockNumber;
            }
            this.realDataChart.ChartAreas[0].AxisX.Title = "Day";
            this.realDataChart.ChartAreas[0].AxisY.Title = "Stock Price";
        }

        private Series createSerieForChart(int stockNumber, int days, Color color)
        {
            Stock stock = stockManager.RealDataStocks.ElementAt(stockNumber);
            double[] prices = stock.GetPricesSince(days).ToArray();
            Series serie = new Series();
            serie.ChartType = SeriesChartType.FastLine;
            serie.Name = stock.Name;
            serie.Color = color;
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

        private Color getRandomColor()
        {
            Random random = new Random();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
