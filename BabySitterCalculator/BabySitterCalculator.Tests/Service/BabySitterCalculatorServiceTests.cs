using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitterCalculator.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BabySitterCalculator.Models;

namespace BabySittingCalculator.Tests
{
    [TestClass()]
    public class BabySitterCalculatorServiceTests
    {
        [TestMethod()]
        public void CalculateServiceChargeTest()
        {
            BabySitterCalculatorServiceModel inputBabySitterCalculatorServiceModel = new BabySitterCalculatorServiceModel();
            inputBabySitterCalculatorServiceModel.StartTime = "5:00 PM";
            inputBabySitterCalculatorServiceModel.EndTime = "10:00 PM";
            BabySitterCalculatorServiceModel resultBabySitterCalculatorServiceModel = BabySitterBillingCalculatorService.calculateServiceCharge(inputBabySitterCalculatorServiceModel);
            Assert.AreEqual(resultBabySitterCalculatorServiceModel.BillingHours, 5);            
            Assert.AreEqual(resultBabySitterCalculatorServiceModel.BillingCharge, 56);
        }
    }
}