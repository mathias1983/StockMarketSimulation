namespace StockMarketSimulation
{
    partial class BuySellHistory
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableView = new System.Windows.Forms.DataGridView();
            this.agentMoneyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMoneyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Location = new System.Drawing.Point(12, 12);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(510, 526);
            this.tableView.TabIndex = 0;
            this.tableView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableView_RowHeaderMouseClick);
            // 
            // agentMoneyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.agentMoneyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.agentMoneyChart.Legends.Add(legend1);
            this.agentMoneyChart.Location = new System.Drawing.Point(528, 12);
            this.agentMoneyChart.Name = "agentMoneyChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Stock";
            this.agentMoneyChart.Series.Add(series1);
            this.agentMoneyChart.Size = new System.Drawing.Size(546, 526);
            this.agentMoneyChart.TabIndex = 5;
            this.agentMoneyChart.Text = "Terna-Simulation";
            // 
            // BuySellHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 550);
            this.Controls.Add(this.agentMoneyChart);
            this.Controls.Add(this.tableView);
            this.Name = "BuySellHistory";
            this.Text = "BuySellHistory";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMoneyChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.DataVisualization.Charting.Chart agentMoneyChart;
    }
}