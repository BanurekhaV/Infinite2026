using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_Prj1.Models;

namespace Web_API_Prj1.Controllers
{
    [RoutePrefix("api/User")]
    public class PersonController : ApiController
    {
        static List<Person> personslist = new List<Person>()
        {
            new  Person {Id = 1, PersonName = "Yudishter", JobTitle = "King", Gender="Male"},
            new  Person {Id = 2, PersonName = "Draupadi", JobTitle = "Queen", Gender="Female"},
            new  Person {Id = 3, PersonName = "Bheem", JobTitle = "Defence Minister", Gender="Male"},
            new  Person {Id = 4, PersonName = "Arjun", JobTitle = "Archerer", Gender="Male"},
            new  Person {Id = 5, PersonName = "Nakul", JobTitle = "Operations", Gender="Male"},
        };

        [HttpGet]
        [Route("All")]
        public IEnumerable<Person>Get()
        {
            return personslist;
        }

        [HttpGet]
        [Route("Bymsg")]
        public HttpResponseMessage GetAllPersons()
        {
            //create a response object with both data and status code
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, personslist);
            return response;

            //incase we want only some info to be sent and not data
            //HttpResponseMessage response = response.Content = new StringContent("Thanks");
            //return reponse;
        }
        [HttpGet]
        [Route("ById")]
        public IHttpActionResult GetPersonNameById(int pid)
        {
            string pname = personslist.Where(p => p.Id == pid).SingleOrDefault().PersonName;

            if(pname == null)
            {
                return NotFound();
            }
            return Ok(pname);
        }

        //Post 1
        [HttpPost]
        [Route("AllPost")]
        public List<Person> PostAll([FromBody] Person person)
        {
            personslist.Add(person);
            return personslist;
        }

        //Post 2
        [HttpPost]
        [Route("PersonPost")]
        public IEnumerable<Person> PersonPost([FromUri] int Id, string name, string job)
        {
            Person person = new Person();
            person.Id = Id;
            person.PersonName = name;
            person.JobTitle = job;
            personslist.Add(person);
            return personslist;
        }

        [HttpPut]
        [Route("updperson")]
        public Person Put(int pid, [FromUri] string name, string job, string gender)
        {
            var Plist = personslist[pid - 1];
            Plist.Id = pid;
            Plist.PersonName = name;
            Plist.JobTitle = job;
            Plist.Gender = gender;
            return Plist;
        }

        [HttpPut]
        [Route("newput")]
        public IEnumerable<Person>Put(int pid, [FromBody] Person p)
        {
            personslist[pid - 1] = p; 
            return personslist;
        }

        [HttpDelete]
        [Route("delperson")]
        public IEnumerable<Person> Delete(int pid)
        {
            personslist.RemoveAt(pid - 1);
            return personslist;
        }
    }
}
