using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NpvWebApplication.Models;

namespace NpvWebApplication.Common
{
    public interface INpvCalculator {
        IList<NpvCashFlow> CalculateCashFlows(NpvInput input);
    }

    public class NpvCalculator : INpvCalculator 
    {
        public IList<NpvCashFlow> CalculateCashFlows(NpvInput input)
        {
            // cash series flows
            List<double> flows = new List<double>();
            for (int i =0; i< input.CashSeries; i++)
            {
                flows.Add( Convert.ToDouble(input.Cash));
            }

            // calc npv base on rate and cash series flows
            var result = new List<NpvCashFlow>();
            decimal rate = input.LowerBound;
            while (rate <= input.UpperBound)
            {
                double npv = flows.Select((c, n) => c / Math.Pow(1 + Convert.ToDouble(rate), n+1)).Sum(); ;

                result.Add(new NpvCashFlow { Rate = rate, Amount = Convert.ToDecimal(npv) });

                rate = rate + input.DiscountRate;
            };

            return result;
        }
    }
}