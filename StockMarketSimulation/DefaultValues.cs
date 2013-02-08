using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class DefaultValues
    {
        public int stopAtEpochNumber = 100;

        public int agentNumber = 50;
        public int maxOrderNumber = 1;
        public int stopLossInterval = 10;

        public float probOfImitatingTheMarket = 0.2F;
        public float probOfLocalImitation = 0.0F;
        public float asymmetricBuySellProb = 0.9F;
        public float agentProbToActBeforeOpening = 0.05F;
        public float minCorrectingCoefficient = 0.9F;
        public float maxCorrectingCoefficient = 1.1F;
        public float floorP = 10F;
        public float agentProbToActBelowFloorPrice = 0.5F;

        public int meanPriceHistoryLength = 20;
        public int localHistoryLength = 5;
        public float agentProbToAdoptStopLoss = 0.3F;
        public float maxLossRate = 0.05F;

        public DefaultValues()
        { }

        public DefaultValues(int _stopAtEpochNumber, int _agentNumber, int _maxOrderNumber, int _stopLossInterval, float _probOfImitatingTheMarket,
                            float _probOfLocalImitation, float _asymmetricBuySellProb, float _agentProbToActBeforeOpening,
                            float _minCorrectingCoefficient, float _maxCorrectingCoefficient, float _floorP, float _agentProbToActBelowFloorPrice,
                            int _meanPriceHistoryLength, int _localHistoryLength, float _agentProbToAdoptStopLoss, float _maxLossRate)
        {
            stopAtEpochNumber = _stopAtEpochNumber;
            agentNumber = _agentNumber;
            maxOrderNumber = _maxOrderNumber;
            stopLossInterval = _stopLossInterval;
            probOfImitatingTheMarket = _probOfImitatingTheMarket;
            asymmetricBuySellProb = _asymmetricBuySellProb;
            agentProbToActBeforeOpening = _agentProbToActBeforeOpening;
            minCorrectingCoefficient = _minCorrectingCoefficient;
            maxCorrectingCoefficient = _maxCorrectingCoefficient;
            floorP = _floorP;
            agentProbToActBelowFloorPrice = _agentProbToActBelowFloorPrice;
            meanPriceHistoryLength = _meanPriceHistoryLength;
            localHistoryLength = _localHistoryLength;
            agentProbToAdoptStopLoss = _agentProbToAdoptStopLoss;
            maxLossRate = _maxLossRate;
        }
    }
}
