using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Web_API_Prj1.Controllers
{
    public class ValuesController : ApiController
    {
        static List<string> str = new List<string>()
        {
            "Value 1", "Value 2", "Value 3","Value 4"
        };
        // GET api/values
        public IEnumerable<string> Get()
        {
            // return new string[] { "value1", "value2","value3","value4"};
            return str;
        }

        // GET api/values/5
        public string Get(int id)
        {
           // return "value";
           return str[id - 1];
        }

        // POST api/values
        public IEnumerable<string> Post([FromBody] string value)
        {
            str.Add(value);
            return str;
        }

        // PUT api/values/5
        public IEnumerable<string> Put(int id, [FromBody] string value)
        {
            str[id -1] = value;
            return str;
        }

        // DELETE api/values/5
        public IEnumerable<string> Delete(int id)
        {
            str.RemoveAt(id - 1);
            return str;
        }
    }
}
