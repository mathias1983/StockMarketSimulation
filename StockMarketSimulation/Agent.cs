using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    class Agent
    {
        int number;
        int maxOrderNumber;
        int stopLossInterval;

        float probOfImitatingTheMarket;
        float probOfLocalImitation;
        float asymmetricBuySellProb;
        float agentProbToActBeforeOpening;
        float minCorrectingCoefficient;
        float maxCorrectingCoefficient;
        float floorP;
        float agentProbToActBelowFloorPrice;

        float meanPriceHistoryLength;
        float agentProbToAdoptStopLoss;
        float maxLossRate;
    }
}
