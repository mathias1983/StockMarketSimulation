namespace StockMarketSimulation
{
    partial class StockLoadDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.numOfStocksTextBox = new System.Windows.Forms.TextBox();
            this.loadStocksButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type in the number of stocks to be loaded:";
            // 
            // numOfStocksTextBox
            // 
            this.numOfStocksTextBox.Location = new System.Drawing.Point(44, 62);
            this.numOfStocksTextBox.Name = "numOfStocksTextBox";
            this.numOfStocksTextBox.Size = new System.Drawing.Size(100, 20);
            this.numOfStocksTextBox.TabIndex = 1;
            this.numOfStocksTextBox.Text = "0";
            // 
            // loadStocksButton
            // 
            this.loadStocksButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loadStocksButton.Location = new System.Drawing.Point(175, 62);
            this.loadStocksButton.Name = "loadStocksButton";
            this.loadStocksButton.Size = new System.Drawing.Size(75, 23);
            this.loadStocksButton.TabIndex = 2;
            this.loadStocksButton.Text = "Load";
            this.loadStocksButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "(0 = all stocks)";
            // 
            // StockLoadDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadStocksButton);
            this.Controls.Add(this.numOfStocksTextBox);
            this.Controls.Add(this.label1);
            this.Name = "StockLoadDialog";
            this.Text = "StockLoadDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numOfStocksTextBox;
        private System.Windows.Forms.Button loadStocksButton;
        private System.Windows.Forms.Label label2;
    }
}