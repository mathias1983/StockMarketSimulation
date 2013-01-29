using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class Agent
    {
        public int number;
        public int maxOrderNumber;
        public int stopLossInterval;

        public float probOfImitatingTheMarket;
        public float probOfLocalImitation;
        public float asymmetricBuySellProb;
        public float agentProbToActBeforeOpening;
        public float minCorrectingCoefficient;
        public float maxCorrectingCoefficient;
        public float floorP;
        public float agentProbToActBelowFloorPrice;

        public int meanPriceHistoryLength;
        public int localHistoryLength;
        public float agentProbToAdoptStopLoss;
        public float maxLossRate;


        public Agent(int number, DefaultValues df)
        {
            this.number = number;
            this.maxOrderNumber = df.maxOrderNumber;
            this.stopLossInterval = df.stopLossInterval;
            this.probOfImitatingTheMarket = df.probOfImitatingTheMarket;
            this.probOfLocalImitation = df.probOfLocalImitation;
            this.asymmetricBuySellProb = df.asymmetricBuySellProb;
            this.agentProbToActBeforeOpening = df.agentProbToActBeforeOpening;
            this.minCorrectingCoefficient = df.minCorrectingCoefficient;
            this.maxCorrectingCoefficient = df.maxCorrectingCoefficient;
            this.floorP = df.floorP;
            this.agentProbToActBelowFloorPrice = df.agentProbToActBelowFloorPrice;
            this.meanPriceHistoryLength = df.meanPriceHistoryLength;
            this.localHistoryLength = df.localHistoryLength;
            this.agentProbToAdoptStopLoss = df.agentProbToAdoptStopLoss;
            this.maxLossRate = df.maxLossRate;

        }
        public int getAgentNumber()
        {
            return this.number;
        }

        public void act(StockPriceBook spb)
        {
            Order tempOrder = new Order();

            float LastPrice = spb.getLastPrice();
            bool bs = true;
            
            double buysellswitch = 0.5;

            if (this.probOfImitatingTheMarket > getRandomDouble())
            {
                if (spb.getPrice(spb.getSize() - 1) > spb.getPrice(spb.getSize() - 2))
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }
                else
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }
            }

            if (this.probOfLocalImitation > getRandomDouble())
            {

            }

            int choice = 1;

            if (buysellswitch < getRandomDouble())
            {
                choice = -1;
            }

            double price = LastPrice * getRandomDouble(this.minCorrectingCoefficient, this.maxCorrectingCoefficient);

            if (LastPrice < this.floorP)
            {
                if (this.agentProbToActBelowFloorPrice > getRandomDouble())
                {
                    price = LastPrice;
                    choice = 1;
                }
            }

            tempOrder.OrderAgentPriceOfOrder = (float)price * choice;
            tempOrder.bs = bs;
            tempOrder.OrderAgentNumber = this.number;

            spb.addOrder(tempOrder);
        }

        private double getRandomDouble()
        {
            Random random = new Random();

            return random.NextDouble();
        }

        private double getRandomDouble(float min, float max)
        {
            Random random = new Random();

            return min + random.NextDouble() * (max - min);
        }

    }
}
