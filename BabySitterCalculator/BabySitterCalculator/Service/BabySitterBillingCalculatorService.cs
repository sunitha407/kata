using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BabySitterCalculator.Models;

namespace BabySitterCalculator.Service
{
    public class BabySitterBillingCalculatorService
    {
        private static IList<KeyValuePair<string, int>> HourlyPriceList = new List<KeyValuePair<string, int>>()
        {
            new KeyValuePair<string, int>("5:00 PM",12),
            new KeyValuePair<string, int>("6:00 PM",12) ,
            new KeyValuePair<string, int>("7:00 PM",12 ) ,
            new KeyValuePair<string, int>("8:00 PM",12 ) ,
            new KeyValuePair<string, int>("9:00 PM",12 ) ,
            new KeyValuePair<string, int>("10:00 PM",8 ) ,
            new KeyValuePair<string, int>("11:00 PM",8 ) ,
            new KeyValuePair<string, int>("12:00 AM",8 ) ,
            new KeyValuePair<string, int>("1:00 AM",16 ) ,
            new KeyValuePair<string, int>("2:00 AM",16 ) ,
            new KeyValuePair<string, int>("3:00 AM",16 ) ,
            new KeyValuePair<string, int>("4:00 AM",16 ) ,

        };
        public static BabySitterCalculatorServiceModel calculateServiceCharge(BabySitterCalculatorServiceModel model)
        {
            string StartTime = model.StartTime;
            string EndTime = model.EndTime;
            bool StartTimeMatchFound = false;
            int HourCounter = 0;
            int PriceCounter = 0;
            foreach (KeyValuePair<string, int> item in HourlyPriceList)
            {
                if (item.Key.Equals(StartTime))
                {
                    StartTimeMatchFound = true;                                      
                    continue;
                }
                if (item.Key.Equals(EndTime))
                {
                    PriceCounter += item.Value;
                    HourCounter++;
                    break;
                }
                if (StartTimeMatchFound)
                {
                    PriceCounter += item.Value;
                    HourCounter++;
                }

            }
            model.BillingCharge = PriceCounter;
            model.BillingHours = HourCounter;
            return model;
        }

       
    }

}
