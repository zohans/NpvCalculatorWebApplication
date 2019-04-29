using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NpvWebApplication.Common;
using NpvWebApplication.Models;

namespace NpvWebApplication.Controllers
{
    public class NpvCalculatorController : ApiController
    {
        private INpvCalculator _npvCalculator;

        public NpvCalculatorController(INpvCalculator npvCalculator)
        {
            _npvCalculator = npvCalculator;
        }

        [HttpPost]
        public IList<NpvCashFlow> CalculateCashFlows(NpvInput input)
        {
            // turn percentage to decimal. 
            // TO DO : move this to front end if time allows
            input.LowerDiscountRateBound = input.LowerDiscountRateBound / 100;
            input.UpperDiscountRateBound= input.UpperDiscountRateBound / 100; 
            input.IncrementDiscountRate= input.IncrementDiscountRate / 100;

            var result = _npvCalculator.CalculateCashFlows(input);

            return result;
        }
    }
}
