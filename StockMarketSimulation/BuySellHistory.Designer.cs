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
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMoneyChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableView
            // 
            this.tableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView.Location = new System.Drawing.Point(0, 0);
            this.tableView.Name = "tableView";
            this.tableView.Size = new System.Drawing.Size(671, 620);
            this.tableView.TabIndex = 0;
            this.tableView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableView_RowHeaderMouseClick);
            // 
            // agentMoneyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.agentMoneyChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.agentMoneyChart.Legends.Add(legend1);
            this.agentMoneyChart.Location = new System.Drawing.Point(689, 12);
            this.agentMoneyChart.Name = "agentMoneyChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Stock";
            this.agentMoneyChart.Series.Add(series1);
            this.agentMoneyChart.Size = new System.Drawing.Size(528, 620);
            this.agentMoneyChart.TabIndex = 5;
            this.agentMoneyChart.Text = "Terna-Simulation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 620);
            this.panel1.TabIndex = 6;
            // 
            // BuySellHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 644);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.agentMoneyChart);
            this.Name = "BuySellHistory";
            this.Text = "BuySellHistory";
            ((System.ComponentModel.ISupportInitialize)(this.tableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentMoneyChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableView;
        private System.Windows.Forms.DataVisualization.Charting.Chart agentMoneyChart;
        private System.Windows.Forms.Panel panel1;
    }
}