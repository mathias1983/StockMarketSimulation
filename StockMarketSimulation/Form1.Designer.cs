namespace StockMarketSimulation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plotRealDataButton = new System.Windows.Forms.Button();
            this.sinceDaysTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.allStocksCheckBox = new System.Windows.Forms.CheckBox();
            this.stockNameComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.realDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStocksMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realDataChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plotRealDataButton);
            this.panel1.Controls.Add(this.sinceDaysTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.allStocksCheckBox);
            this.panel1.Controls.Add(this.stockNameComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 111);
            this.panel1.TabIndex = 0;
            // 
            // plotRealDataButton
            // 
            this.plotRealDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotRealDataButton.Location = new System.Drawing.Point(16, 68);
            this.plotRealDataButton.Name = "plotRealDataButton";
            this.plotRealDataButton.Size = new System.Drawing.Size(252, 40);
            this.plotRealDataButton.TabIndex = 6;
            this.plotRealDataButton.Text = "Plot";
            this.plotRealDataButton.UseVisualStyleBackColor = true;
            this.plotRealDataButton.Click += new System.EventHandler(this.plotRealDataButton_Click);
            // 
            // sinceDaysTextBox
            // 
            this.sinceDaysTextBox.Location = new System.Drawing.Point(83, 37);
            this.sinceDaysTextBox.Name = "sinceDaysTextBox";
            this.sinceDaysTextBox.Size = new System.Drawing.Size(96, 20);
            this.sinceDaysTextBox.TabIndex = 5;
            this.sinceDaysTextBox.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Since Days:";
            // 
            // allStocksCheckBox
            // 
            this.allStocksCheckBox.AutoSize = true;
            this.allStocksCheckBox.Location = new System.Drawing.Point(195, 10);
            this.allStocksCheckBox.Name = "allStocksCheckBox";
            this.allStocksCheckBox.Size = new System.Drawing.Size(73, 17);
            this.allStocksCheckBox.TabIndex = 3;
            this.allStocksCheckBox.Text = "All Stocks";
            this.allStocksCheckBox.UseVisualStyleBackColor = true;
            // 
            // stockNameComboBox
            // 
            this.stockNameComboBox.FormattingEnabled = true;
            this.stockNameComboBox.Location = new System.Drawing.Point(58, 10);
            this.stockNameComboBox.Name = "stockNameComboBox";
            this.stockNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.stockNameComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Stock:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Real Data";
            // 
            // realDataChart
            // 
            chartArea2.Name = "ChartArea1";
            this.realDataChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.realDataChart.Legends.Add(legend2);
            this.realDataChart.Location = new System.Drawing.Point(13, 58);
            this.realDataChart.Name = "realDataChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.realDataChart.Series.Add(series2);
            this.realDataChart.Size = new System.Drawing.Size(388, 375);
            this.realDataChart.TabIndex = 2;
            this.realDataChart.Text = "chart1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadStocksMenu});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadStocksMenu
            // 
            this.loadStocksMenu.Name = "loadStocksMenu";
            this.loadStocksMenu.Size = new System.Drawing.Size(152, 22);
            this.loadStocksMenu.Text = "Load Stocks";
            this.loadStocksMenu.Click += new System.EventHandler(this.loadStocksMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.realDataChart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Stock Market Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.realDataChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button plotRealDataButton;
        private System.Windows.Forms.TextBox sinceDaysTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox allStocksCheckBox;
        private System.Windows.Forms.ComboBox stockNameComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart realDataChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadStocksMenu;
    }
}

