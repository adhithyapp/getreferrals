using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class referralsController : ControllerBase
    {
        // GET: api/referrals
        [HttpGet]
        public IEnumerable<referralsclass> Get()
        {
            List<referralsclass> referralsClassList = new List<referralsclass>();
            referralsclass r1 = new referralsclass("pp", "adhithya", "9995574970", "albam");
            referralsClassList.Add(r1);
            return referralsClassList;
        }

        // GET: api/referrals/5
        [HttpGet("{id}", Name = "referralsGet")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/referrals
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/referrals/5
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

    public class referralsclass
    {
        public referralsclass(string lastName1,string firstName1,string contactNumber1,string office1)
        {
            lastName = lastName1;
            firstName = firstName1;
            contactNumber = contactNumber1;
            office = office1;
            
        }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string contactNumber { get; set; }
        public string office { get; set; }
    }
}
