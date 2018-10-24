using System;
using System.Collections.Generic;

using System.Web.Http;
using BabySitterCalculator.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Web.Http.Description;
using BabySitterCalculator.Service;


namespace BabySitterCalculator.Controllers
{
    public class BabySitterCalculatorServiceController : ApiController
    {

        [System.Web.Http.Route("api/BillingCalculator")]
        [System.Web.Http.HttpPost]
        public async Task<IHttpActionResult> GetServiceHoursAndBillingChargesAsync(BabySitterCalculatorServiceModel model)
        {
            if (model.StartTime!= null && model.EndTime != null)
            {
                BabySitterCalculatorServiceModel updatedModel = await Task.Run(()=> BabySitterBillingCalculatorService.calculateServiceCharge(model));
                return Ok(updatedModel);
            }
            else
            {
                return BadRequest(ModelState);
            }          

        }
       
    }
}
