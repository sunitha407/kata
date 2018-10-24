
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace BabySitterCalculator.Models
{

    public class BabySitterCalculatorModel
    {

        public static IEnumerable<SelectListItem> StartTimeDropDownList;
        public static IEnumerable<SelectListItem> EndTimeDropDownList;
        public string selectedStartTime { get; set; }
        public string selectedEndTime { get; set; }
        [Display(Name = "Billing Hours")]
        public int BillingHours { get; set; }
        [Display(Name = "Billing Charges")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double BillingCharges { get; set; }
        
        public BabySitterCalculatorModel()
        {
            BillingHours = 0;
            BillingCharges = 0.0;
          
        }
        static BabySitterCalculatorModel()
        {
            StartTimeDropDownList = Utils.SelectItemUtility.GetSelectListItems(GetAllStartTime());
            EndTimeDropDownList = Utils.SelectItemUtility.GetSelectListItems(GetAllEndTime());
        }
        private static IEnumerable<string> GetAllStartTime()
        {
            List<string> listOfStartingHours = GetAllValidHours();
            listOfStartingHours.RemoveAt(listOfStartingHours.Count - 1);
            return listOfStartingHours.AsEnumerable();
        }
        private static IEnumerable<string> GetAllEndTime()
        {
            List<string> listOfEndingHours = GetAllValidHours();
            listOfEndingHours.RemoveAt(0);
            return listOfEndingHours.AsEnumerable();
        }
        private static List<string> GetAllValidHours()
        {
            return new List<string>
            {
                "5:00 PM",
                "6:00 PM",
                "7:00 PM",
                "8:00 PM",
                "9:00 PM",
                "10:00 PM",
                "11:00 PM",
                "12:00 AM",
                "1:00 AM",
                "2:00 AM",
                "3:00 AM",
                "4:00 AM"
            };
        }
       
    }
}