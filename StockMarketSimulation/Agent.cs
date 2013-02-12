﻿using System;
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

        // Without static Random always the same result with nextdouble() 

        private static Random random = new Random();

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

        public Order act()
        {
            Order tempOrder = new Order();

            double LastPrice = StockMarketSimulation.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);
            //double LastPrice = StockMarketSimulation.stockPriceBook.getLastPrice();

            double buysellswitch = 0.5;

            if (this.probOfImitatingTheMarket > getRandomDouble())
            {
                if (getMeanPriceOfTwoDaysBefore() < getMeanPriceOfDayBefore())
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }
                if (getMeanPriceOfTwoDaysBefore() > getMeanPriceOfDayBefore())
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }
            }

            int choice = 1;

            if (this.probOfLocalImitation > getRandomDouble())
            {
                int tempDecision = getDecisionsOfLastAgents(this.localHistoryLength);
                if (tempDecision > 0)
                {
                    buysellswitch = this.asymmetricBuySellProb;
                }
                if (tempDecision < 0)
                {
                    buysellswitch = 1 - this.asymmetricBuySellProb;
                }


            }

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

            int stopLossChoice = 1;
            double stopLossMeanPrice = StockMarketSimulation.stockPriceBook.getMeanPrice(this.stopLossInterval);

            if (LastPrice >= stopLossMeanPrice * (1 + this.maxLossRate))
                stopLossChoice = 1;
            if (LastPrice <= stopLossMeanPrice * (1 - this.maxLossRate))
                stopLossChoice = -1;

            if (this.agentProbToAdoptStopLoss > getRandomDouble())
            {
                price = LastPrice;
                choice = stopLossChoice;
            }

            tempOrder.OrderAgentPriceOfOrder = (float)price * choice;
            tempOrder.OrderAgentNumber = this.number;
            tempOrder.simulationDay = StockMarketSimulation.simDay;


            StockMarketSimulation.stockPriceBook.setLastPrice((float)price * choice);

            return tempOrder;
        }

        private int getDecisionsOfLastAgents(int length)
        {
            return StockMarketSimulation.stockPriceBook.getLocalHistory(length);
        }

        private double getMeanPriceOfDayBefore()
        {
            return StockMarketSimulation.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 1);
        }

        private double getMeanPriceOfTwoDaysBefore()
        {

            return StockMarketSimulation.stockPriceBook.getEndofDayPrice(StockMarketSimulation.simDay - 2);
        }

        private double getRandomDouble()
        {
            double a = random.NextDouble();

            return a;
        }

        private double getRandomDouble(float min, float max)
        {
            double a = random.NextDouble();
            return min + a * (max - min);
        }
    }
}
