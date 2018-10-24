using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BabySitterCalculator.Models
{
    public class BabySitterCalculatorServiceModel
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int BillingHours { get; set; }
        public double BillingCharge { get; set; }
    }
}