﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockMarketSimulation
{
    public class DefaultValues
    {
        public int stopAtEpochNumber = 2000;

        public int ternaAgentNumber = 50;
        public int randomAgentNumber = 50;
        public int raAgentNumber = 20;
        public int rsAgentNumber = 20;

        public int NumberOfAllAgents
        { get { return ternaAgentNumber + randomAgentNumber + raAgentNumber + rsAgentNumber; } }

        public int stockNumber = 5;
        public int budget = 200000;
        public int maxOrderNumber = 1;
        public int stopLossInterval = 1;

        public float probOfImitatingTheMarket = 0.0F;
        public float probOfLocalImitation = 0.0F;
        public float asymmetricBuySellProb = 0.9F;
        public float agentProbToActBeforeOpening = 0.05F;
        public float minCorrectingCoefficient = 0.95F;
        public float maxCorrectingCoefficient = 1.051F;
        public float floorP = 1F;
        public float agentProbToActBelowFloorPrice = 0.0F;

        public int meanPriceHistoryLength = 2;
        public int localHistoryLength = 20;
        public float agentProbToAdoptStopLoss = 0.5F;
        public float maxLossRate = 0.0F;

        public DefaultValues()
        { }

        public DefaultValues(int _stopAtEpochNumber, int _ternaAgentNumber, int _randomAgentNumber, int _raAgentNumber, int _rsAgentNumber, int _stockNumber, int _budget, int _maxOrderNumber, int _stopLossInterval, float _probOfImitatingTheMarket,
                            float _probOfLocalImitation, float _asymmetricBuySellProb, float _agentProbToActBeforeOpening,
                            float _minCorrectingCoefficient, float _maxCorrectingCoefficient, float _floorP, float _agentProbToActBelowFloorPrice,
                            int _meanPriceHistoryLength, int _localHistoryLength, float _agentProbToAdoptStopLoss, float _maxLossRate)
        {
            stopAtEpochNumber = _stopAtEpochNumber;
            ternaAgentNumber = _ternaAgentNumber;
            randomAgentNumber = _randomAgentNumber;
            rsAgentNumber = _rsAgentNumber;
            raAgentNumber = _raAgentNumber;
            stockNumber = _stockNumber;
            budget = _budget;
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
