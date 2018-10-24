using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabySitterCalculator.Utils
{
    public static class SelectItemUtility
    {
        public static IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {

            var selectList = new List<SelectListItem>();
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }
            return selectList;
        }
    }
}