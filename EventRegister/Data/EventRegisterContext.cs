using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EventRegister.Data
{
    public class EventRegisterContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}