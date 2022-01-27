using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace a1_seantrudeln01525609_http5112webdev1c.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()    //requests multiple strings
        {
            return new string[] { "value3", "value4", "values5" }; //returns multiple strings
        }

        // GET api/values/5     <-any number can be written, which updates int id
        //input : integer
        //output : the next four integers after the input
        //public string Get(int id)

        /*public IEnumerable<int> Get(int id)
        {
            return new int[] { id+1, id+2, id+3, id+4};
        }*/

        //challenge 1: output half of the input (rounded down)
        public int Get(int id)
        {
            return id/2;
        }


        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
