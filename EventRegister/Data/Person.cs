using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegister.Data
{
    public class Person
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string PhoneNumber { get; set; }
        public string AgeGroup { get; set; }
    }
}