using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class DefaultValues
    {
        public int agentNumber = 100;
        public int maxOrderNumber = 1;
        public int stopLossInterval = 1;

        public float probOfImitatingTheMarket = 0.0F;
        public float probOfLocalImitation = 0.0F;
        public float asymmetricBuySellProb = 0.9F;
        public float agentProbToActBeforeOpening = 0.05F;
        public float minCorrectingCoefficient = 0.9F;
        public float maxCorrectingCoefficient = 1.1F;
        public float floorP = 0.3F;
        public float agentProbToActBelowFloorPrice = 0.5F;

        public int meanPriceHistoryLength = 100;
        public int localHistoryLength = 100;
        public float agentProbToAdoptStopLoss = 0.0F;
        public float maxLossRate = 0.05F;
    }
}
