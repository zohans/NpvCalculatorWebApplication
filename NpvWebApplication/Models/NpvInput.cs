using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NpvWebApplication.Models
{
    public partial class NpvInput
    {
        public decimal Cash { get; set; }
        public decimal CashSeries { get; set; }
        public decimal LowerDiscountRateBound { get; set; }
        public decimal UpperDiscountRateBound { get; set; }
        public decimal IncrementDiscountRate { get; set; }
    }
}