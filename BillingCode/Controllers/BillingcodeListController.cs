using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BillingCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillingcodeListController : ControllerBase
    {
        // GET: api/BillingcodeList
        [HttpGet]
        public IEnumerable<BillingCode> Get()
        {

            List<BillingCode> billingCodeList = new List<BillingCode>();
            BillingCode b1 = new BillingCode(billingCode: "322", billingDescription: "Request for Anticipated Payment (RAP)");
            BillingCode b2 = new BillingCode(billingCode: "327", billingDescription: "Adjustment Claim");
            BillingCode b3 = new BillingCode(billingCode: "328", billingDescription: "Void/Cancel Prior RAP/Claim");
            BillingCode b4 = new BillingCode(billingCode: "329", billingDescription: "Final Claim for Episode");
            BillingCode b5 = new BillingCode(billingCode: "320", billingDescription: "Nonpayment Claim");
            BillingCode b6 = new BillingCode(billingCode: "34X", billingDescription: "Outpatient Services");
            BillingCode b7 = new BillingCode(billingCode: "3XQ", billingDescription: "Reopening");
            BillingCode b8 = new BillingCode(billingCode: "3XG", billingDescription: "Contractor adjustment");
            BillingCode b9 = new BillingCode(billingCode: "3XI", billingDescription: "Contractor adjustment");

            billingCodeList.Add(b1);
            billingCodeList.Add(b2);
            billingCodeList.Add(b3);
            billingCodeList.Add(b4);
            billingCodeList.Add(b5);
            billingCodeList.Add(b6);
            billingCodeList.Add(b7);
            billingCodeList.Add(b8);
            billingCodeList.Add(b9);

            return billingCodeList;
        }

        // GET: api/BillingcodeList/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BillingcodeList
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/BillingcodeList/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class BillingCode
    {
        public string billingCode { get; set; }
        public string billingDescription { get; set; }

        public BillingCode(string billingCode, string billingDescription)
        {
            this.billingCode = billingCode;
            this.billingDescription = billingDescription;
        }

       
    }
}
