using JsonFeedApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace JsonFeedApi.Controllers
{
  //  [Route("api/[controller]")]
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Jobs> Get()
        {
            return new Jobs[] { new Jobs {Sort = 1,Company = "Kwick staffing",Province ="Ontario",City ="Scarbrough",Title = "Shipping & receiving",Description= " Motor Works is a family-owned business, " +
                "established in 1993 with one location in Toronto." +
                "Over the past 20 years, Avenue has expanded to meet the growing customer demand throughout Central Ontario",
                Responsibility = "Ability to receive, put away and locate parts in warehouse with speed and accuracy using their alpha-numeric part numbers" +
                "Pick and package orders using Purolator Use of stairs and ladders to access parts in all areas of the warehouse Strength to lift and carry " +
                "loads up to 10-30lbs on a regular basis and up to 50lbs when requiredProblem solving skills and the ability " +
                "to communicate effectively with co-workers - both verbally and in writing",Salary= 10,Phone = "6478889999",Latitude=43.781883,Longitude=-79.236121,Image ="Pic_1" }
            , new Jobs {Sort = 2,Company = "Great Connections ",Province ="Ontario",City ="Toronto",Title = "Labour",Description= " Motor Works is a family-owned business, " +
                "established in 1993 with one location in Toronto." +
                "Over the past 20 years, Avenue has expanded to meet the growing customer demand throughout Central Ontario",
                Responsibility = "Ability to receive, put away and locate parts in warehouse with speed and accuracy using their alpha-numeric part numbers" +
                "Pick and package orders using Purolator Use of stairs and ladders to access parts in all areas of the warehouse Strength to lift and carry " +
                "loads up to 10-30lbs on a regular basis and up to 50lbs when requiredProblem solving skills and the ability " +
                "to communicate effectively with co-workers - both verbally and in writing",Salary= 20,Phone = "6478887799",Latitude=43.783248,Longitude=-79.471398,Image ="Pic_2" } 
            , new Jobs {Sort = 3,Company = "Labour Ready ",Province ="Ontario",City ="Toronto",Title = "Labour",Description= " Motor Works is a family-owned business, " +
                "established in 1993 with one location in Toronto." +
                "Over the past 20 years, Avenue has expanded to meet the growing customer demand throughout Central Ontario",
                Responsibility = "Ability to receive, put away and locate parts in warehouse with speed and accuracy using their alpha-numeric part numbers" +
                "Pick and package orders using Purolator Use of stairs and ladders to access parts in all areas of the warehouse Strength to lift and carry " +
                "loads up to 10-30lbs on a regular basis and up to 50lbs when requiredProblem solving skills and the ability " +
                "to communicate effectively with co-workers - both verbally and in writing",Salary= 40,Phone = "6478887799",Latitude=43.771266,Longitude=-79.271696 ,Image ="Pic_3" } };
        }

        // GET api/values/5
        public Jobs Get(string id)
        {
            return new Jobs{ Sort = 1};
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
