using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    public class PeopleController : ApiController
    {
        List<Person> people = new List<Person>();
        // GET api/people
        public PeopleController()
        {
            people.Add(new Person { FirstName = "Tim", LastName = "Storm", Id = 1 });
            people.Add(new Person { FirstName = "Sue", LastName = "Corey", Id = 2 });
            people.Add(new Person { FirstName = "Bilbo", LastName = "Corey", Id = 3 });
        }
        public List<Person> Get()
        {
            return people;
        }

        // GET api/people/5
        public Person Get(int id)
        
        {
            var count = people.Count;
            return people.Where(x => x.Id == id).FirstOrDefault();
        }


        [Route("api/People/GetLastname")]
        [HttpGet]
        public List<string> GetLastname()
        {
            List<string> surnames = new List<string>();

            foreach (var p in people)
            {
                surnames.Add(p.LastName);
            }

            return surnames;
        }

        // POST api/people
        public void Post([FromBody] Person value)
        {
            people.Add((Person)value);  
        }

        // PUT api/people/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/people/5
        public void Delete(int id)
        {
        }
    }
}
