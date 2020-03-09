using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Carter.Test.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Carter.Test.Api.Controllers
{
    [Route("api/[controller]/shipment")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpPost]
        public ActionResult shipment([FromBody]shipment model)
        {
            string fvShipmentId = model.carrier.fvCarrierId + "|" + model.customer.fvCustomerId + "|" + model.shipmentIdentification.shipmentId;
            Response.Headers.Add("X-WSS-fvShipmentId", fvShipmentId);
            return Ok();
        }

        [HttpPut]
        public ActionResult updateshipment([FromBody]shipment model)
        {
            Random random = new Random();
            int num = random.Next(2);
            string fvShipmentId = model.carrier.fvCarrierId + "|" + model.customer.fvCustomerId + "|" + model.shipmentIdentification.shipmentId;
            Response.Headers.Add("X-WSS-fvShipmentId", fvShipmentId);
            return Ok();
        }

        [HttpPost("event")]
        public ActionResult shipmentevent([FromBody]shipment model)
        {
            Random random = new Random();
            int num = random.Next(2);
            return StatusCode(200);
        }
    }
}