using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BabySitterCalculator.Models;

namespace BabySitterCalculator.Controllers
{
    public class BabySitterCalculatorController : Controller
    {
    
        public ActionResult Index()
        {
            BabySitterCalculatorModel model = new BabySitterCalculatorModel();
           return View("../BabySitter/BabySitterCalculatorView", model);
        }
    }
}