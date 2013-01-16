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
    public partial class StockLoadDialog : Form
    {
        public StockLoadDialog()
        {
            InitializeComponent();
        }

        public int NumOfStocks
        {
            get { return Int32.Parse(this.numOfStocksTextBox.Text); }
        }
    }
}
