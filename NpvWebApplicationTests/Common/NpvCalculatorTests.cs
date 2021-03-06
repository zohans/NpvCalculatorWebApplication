﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NpvWebApplication.Common;
using NpvWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NpvWebApplication.Common.Tests
{
    [TestClass()]
    public class NpvCalculatorTests
    {
        [TestMethod()]
        public void CalculateCashFlows_Should_be_passed_when_testing_npv_amount_for_given_inputs()
        {
            // Arrange            
            INpvCalculator calculator = new NpvCalculator();
            NpvInput input = new NpvInput ();
            input.Cash = 100m;
            input.CashSeries = 10m;
            input.IncrementDiscountRate = 0.0025m;
            input.LowerDiscountRateBound = 0.01m;
            input.UpperDiscountRateBound = 0.15m;

            // Act
            var npvCashFlows = calculator.CalculateCashFlows(input);

            // Assert
            var npvCashFlow = npvCashFlows.Where(c => c.Rate == 0.01m).SingleOrDefault<NpvCashFlow>();
            var npvCashFlow2 = npvCashFlows.Where(c => c.Rate == 0.1m).SingleOrDefault<NpvCashFlow>();
            var npvCashFlow3 = npvCashFlows.Where(c => c.Rate == 0.15m).SingleOrDefault<NpvCashFlow>();

            Assert.IsTrue(npvCashFlows.Count() > 0 );            

            Assert.IsTrue(Math.Round(npvCashFlow.Amount,2) == 947.13m);
            Assert.IsTrue(Math.Round(npvCashFlow2.Amount, 2) == 614.46m);
            Assert.IsTrue(Math.Round(npvCashFlow3.Amount, 2) == 501.88m);            
        }
    }
}
