namespace StockMarketSimulation
{
    partial class AgentSettingsDialog
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
            this.numberOfTernaAgentsTextBox = new System.Windows.Forms.TextBox();
            this.maxOrdersTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stopLossTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.probImitatingMarketTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.probLocalImitationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.asymmetricTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.probBeforeOpeningTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.minCorTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxCorTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.agentProbActBelowFloorPriceTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.floorPriceTextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.localHostoryLengthTextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.meanPriceHistoryLengthTextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.maxLossRateTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.agentProbAdoptStopLossTextbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.epochNumberTextbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.budgetTextbox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numOfStocksTextbox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numberOfRandomAgentsTextbox = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numberOfIntelligentAgentTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Agents";
            // 
            // numberOfTernaAgentsTextBox
            // 
            this.numberOfTernaAgentsTextBox.Location = new System.Drawing.Point(294, 57);
            this.numberOfTernaAgentsTextBox.Name = "numberOfTernaAgentsTextBox";
            this.numberOfTernaAgentsTextBox.Size = new System.Drawing.Size(50, 20);
            this.numberOfTernaAgentsTextBox.TabIndex = 1;
            this.numberOfTernaAgentsTextBox.Text = "50";
            // 
            // maxOrdersTextBox
            // 
            this.maxOrdersTextBox.Location = new System.Drawing.Point(499, 61);
            this.maxOrdersTextBox.Name = "maxOrdersTextBox";
            this.maxOrdersTextBox.Size = new System.Drawing.Size(50, 20);
            this.maxOrdersTextBox.TabIndex = 3;
            this.maxOrdersTextBox.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Max Orders:";
            // 
            // stopLossTextBox
            // 
            this.stopLossTextBox.Location = new System.Drawing.Point(120, 83);
            this.stopLossTextBox.Name = "stopLossTextBox";
            this.stopLossTextBox.Size = new System.Drawing.Size(50, 20);
            this.stopLossTextBox.TabIndex = 5;
            this.stopLossTextBox.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Stop Loss Interval:";
            // 
            // probImitatingMarketTextbox
            // 
            this.probImitatingMarketTextbox.Location = new System.Drawing.Point(198, 136);
            this.probImitatingMarketTextbox.Name = "probImitatingMarketTextbox";
            this.probImitatingMarketTextbox.Size = new System.Drawing.Size(50, 20);
            this.probImitatingMarketTextbox.TabIndex = 7;
            this.probImitatingMarketTextbox.Text = "0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Prob. of Imitating the Market:";
            // 
            // probLocalImitationTextBox
            // 
            this.probLocalImitationTextBox.Location = new System.Drawing.Point(198, 162);
            this.probLocalImitationTextBox.Name = "probLocalImitationTextBox";
            this.probLocalImitationTextBox.Size = new System.Drawing.Size(50, 20);
            this.probLocalImitationTextBox.TabIndex = 9;
            this.probLocalImitationTextBox.Text = "0.1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prob. of local Imitation:";
            // 
            // asymmetricTextbox
            // 
            this.asymmetricTextbox.Location = new System.Drawing.Point(198, 188);
            this.asymmetricTextbox.Name = "asymmetricTextbox";
            this.asymmetricTextbox.Size = new System.Drawing.Size(50, 20);
            this.asymmetricTextbox.TabIndex = 11;
            this.asymmetricTextbox.Text = "0.9";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Asymmetric Buy Sell Prob.:";
            // 
            // probBeforeOpeningTextbox
            // 
            this.probBeforeOpeningTextbox.Location = new System.Drawing.Point(198, 214);
            this.probBeforeOpeningTextbox.Name = "probBeforeOpeningTextbox";
            this.probBeforeOpeningTextbox.Size = new System.Drawing.Size(50, 20);
            this.probBeforeOpeningTextbox.TabIndex = 13;
            this.probBeforeOpeningTextbox.Text = "0.05";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Agent Prob to Act Before Opening:";
            // 
            // minCorTextbox
            // 
            this.minCorTextbox.Location = new System.Drawing.Point(198, 240);
            this.minCorTextbox.Name = "minCorTextbox";
            this.minCorTextbox.Size = new System.Drawing.Size(50, 20);
            this.minCorTextbox.TabIndex = 15;
            this.minCorTextbox.Text = "0.9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Min Correcting Coefficient:";
            // 
            // maxCorTextbox
            // 
            this.maxCorTextbox.Location = new System.Drawing.Point(198, 266);
            this.maxCorTextbox.Name = "maxCorTextbox";
            this.maxCorTextbox.Size = new System.Drawing.Size(50, 20);
            this.maxCorTextbox.TabIndex = 17;
            this.maxCorTextbox.Text = "1.1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Max Correcting Coefficient:";
            // 
            // agentProbActBelowFloorPriceTextbox
            // 
            this.agentProbActBelowFloorPriceTextbox.Location = new System.Drawing.Point(491, 162);
            this.agentProbActBelowFloorPriceTextbox.Name = "agentProbActBelowFloorPriceTextbox";
            this.agentProbActBelowFloorPriceTextbox.Size = new System.Drawing.Size(50, 20);
            this.agentProbActBelowFloorPriceTextbox.TabIndex = 21;
            this.agentProbActBelowFloorPriceTextbox.Text = "0.5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Agent Prob. to Act below Floor Price:";
            // 
            // floorPriceTextbox
            // 
            this.floorPriceTextbox.Location = new System.Drawing.Point(491, 136);
            this.floorPriceTextbox.Name = "floorPriceTextbox";
            this.floorPriceTextbox.Size = new System.Drawing.Size(50, 20);
            this.floorPriceTextbox.TabIndex = 19;
            this.floorPriceTextbox.Text = "0.3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Floor Price:";
            // 
            // localHostoryLengthTextbox
            // 
            this.localHostoryLengthTextbox.Location = new System.Drawing.Point(491, 214);
            this.localHostoryLengthTextbox.Name = "localHostoryLengthTextbox";
            this.localHostoryLengthTextbox.Size = new System.Drawing.Size(50, 20);
            this.localHostoryLengthTextbox.TabIndex = 25;
            this.localHostoryLengthTextbox.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(306, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Local History Length:";
            // 
            // meanPriceHistoryLengthTextbox
            // 
            this.meanPriceHistoryLengthTextbox.Location = new System.Drawing.Point(491, 188);
            this.meanPriceHistoryLengthTextbox.Name = "meanPriceHistoryLengthTextbox";
            this.meanPriceHistoryLengthTextbox.Size = new System.Drawing.Size(50, 20);
            this.meanPriceHistoryLengthTextbox.TabIndex = 23;
            this.meanPriceHistoryLengthTextbox.Text = "100";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(306, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Mean Price History Length:";
            // 
            // maxLossRateTextBox
            // 
            this.maxLossRateTextBox.Location = new System.Drawing.Point(491, 266);
            this.maxLossRateTextBox.Name = "maxLossRateTextBox";
            this.maxLossRateTextBox.Size = new System.Drawing.Size(50, 20);
            this.maxLossRateTextBox.TabIndex = 29;
            this.maxLossRateTextBox.Text = "0.05";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(306, 269);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Max Loss Rate:";
            // 
            // agentProbAdoptStopLossTextbox
            // 
            this.agentProbAdoptStopLossTextbox.Location = new System.Drawing.Point(491, 240);
            this.agentProbAdoptStopLossTextbox.Name = "agentProbAdoptStopLossTextbox";
            this.agentProbAdoptStopLossTextbox.Size = new System.Drawing.Size(50, 20);
            this.agentProbAdoptStopLossTextbox.TabIndex = 27;
            this.agentProbAdoptStopLossTextbox.Text = "0.0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(306, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Agent Prob. to Adopt Stop Loss:";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(403, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 58);
            this.button1.TabIndex = 30;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // epochNumberTextbox
            // 
            this.epochNumberTextbox.Location = new System.Drawing.Point(120, 6);
            this.epochNumberTextbox.Name = "epochNumberTextbox";
            this.epochNumberTextbox.Size = new System.Drawing.Size(50, 20);
            this.epochNumberTextbox.TabIndex = 32;
            this.epochNumberTextbox.Text = "200";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(22, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Epoch Number:";
            // 
            // budgetTextbox
            // 
            this.budgetTextbox.Location = new System.Drawing.Point(499, 32);
            this.budgetTextbox.Name = "budgetTextbox";
            this.budgetTextbox.Size = new System.Drawing.Size(50, 20);
            this.budgetTextbox.TabIndex = 34;
            this.budgetTextbox.Text = "1000";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(401, 35);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Agent Budget:";
            // 
            // numOfStocksTextbox
            // 
            this.numOfStocksTextbox.Location = new System.Drawing.Point(120, 35);
            this.numOfStocksTextbox.Name = "numOfStocksTextbox";
            this.numOfStocksTextbox.Size = new System.Drawing.Size(50, 20);
            this.numOfStocksTextbox.TabIndex = 36;
            this.numOfStocksTextbox.Text = "5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(22, 38);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Number of Stocks:";
            // 
            // numberOfRandomAgentsTextbox
            // 
            this.numberOfRandomAgentsTextbox.Location = new System.Drawing.Point(294, 31);
            this.numberOfRandomAgentsTextbox.Name = "numberOfRandomAgentsTextbox";
            this.numberOfRandomAgentsTextbox.Size = new System.Drawing.Size(50, 20);
            this.numberOfRandomAgentsTextbox.TabIndex = 37;
            this.numberOfRandomAgentsTextbox.Text = "50";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(236, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Terna:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(236, 35);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Random:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(236, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 41;
            this.label21.Text = "Intelligent:";
            // 
            // numberOfIntelligentAgentTextbox
            // 
            this.numberOfIntelligentAgentTextbox.Enabled = false;
            this.numberOfIntelligentAgentTextbox.Location = new System.Drawing.Point(294, 83);
            this.numberOfIntelligentAgentTextbox.Name = "numberOfIntelligentAgentTextbox";
            this.numberOfIntelligentAgentTextbox.Size = new System.Drawing.Size(50, 20);
            this.numberOfIntelligentAgentTextbox.TabIndex = 40;
            this.numberOfIntelligentAgentTextbox.Text = "0";
            // 
            // AgentSettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 373);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.numberOfIntelligentAgentTextbox);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.numberOfRandomAgentsTextbox);
            this.Controls.Add(this.numOfStocksTextbox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.budgetTextbox);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.epochNumberTextbox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxLossRateTextBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.agentProbAdoptStopLossTextbox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.localHostoryLengthTextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.meanPriceHistoryLengthTextbox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.agentProbActBelowFloorPriceTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.floorPriceTextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxCorTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minCorTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.probBeforeOpeningTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.asymmetricTextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.probLocalImitationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.probImitatingMarketTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stopLossTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxOrdersTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberOfTernaAgentsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AgentSettingsDialog";
            this.Text = "AgentSettingsDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfTernaAgentsTextBox;
        private System.Windows.Forms.TextBox maxOrdersTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox stopLossTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox probImitatingMarketTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox probLocalImitationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox asymmetricTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox probBeforeOpeningTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minCorTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxCorTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox agentProbActBelowFloorPriceTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox floorPriceTextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox localHostoryLengthTextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox meanPriceHistoryLengthTextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox maxLossRateTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox agentProbAdoptStopLossTextbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox epochNumberTextbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox budgetTextbox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox numOfStocksTextbox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox numberOfRandomAgentsTextbox;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox numberOfIntelligentAgentTextbox;
    }
}