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
            var result = _npvCalculator.CalculateCashFlows(input);

            return result;
        }
    }
}
