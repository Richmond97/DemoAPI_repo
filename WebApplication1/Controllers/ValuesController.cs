using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    public class ValuesController : ApiController
    {
        List<Person> people = new List<Person>();
        // GET api/values
        public List<Person> Get()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Storm", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Corey", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Corey", Id = 3 });

            return people;
        }

        // GET api/values/5
        public Person Get(int id)
        {
           return people.Where(x => x.Id == id).FirstOrDefault();
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
