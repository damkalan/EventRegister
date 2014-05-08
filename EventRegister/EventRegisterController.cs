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
        // GET api/<controller>
        public IEnumerable<PersonViewModel> Get()
        {
            List<PersonViewModel> persons = new List<PersonViewModel> {
                new PersonViewModel{
                    FirstName = "Kolpan",
                    LastName = "Lopertkety",
                    MiddleInitial = "B",
                    PhoneNumber = "458-698-756",
                    AgeGroup = "2"
                },

                new PersonViewModel{
                    FirstName = "Polod",
                    LastName = "Moerlokusez",
                    MiddleInitial = "F",
                    PhoneNumber = "254-657-458",
                    AgeGroup = "2"                        
                }
            };

            return persons;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
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