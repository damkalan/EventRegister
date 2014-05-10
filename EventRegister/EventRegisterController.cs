using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EventRegister
{
    public class EventRegisterController : ApiController
    {
        EventRegisterService eventRegisterService = new EventRegisterService();

        // GET api/<controller>
        public IEnumerable<PersonViewModel> Get()
        {
            return eventRegisterService.getPersonList();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post(PersonViewModel person)
        {
            eventRegisterService.save(person);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}