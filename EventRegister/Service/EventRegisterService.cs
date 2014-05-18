using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventRegister.Data;

namespace EventRegister
{
    public class EventRegisterService
    {
        private static List<Person> personStore;

        static EventRegisterService()
        {
            personStore = new List<Person> {
                new Person{
                    FirstName = "Kolpan",
                    LastName = "Lopertkety",
                    MiddleInitial = "B",
                    PhoneNumber = "458-698-756",
                    AgeGroup = "2"
                },
                new Person{
                    FirstName = "Polod",
                    LastName = "Moerlokusez",
                    MiddleInitial = "F",
                    PhoneNumber = "254-657-458",
                    AgeGroup = "2"
                }
            };
        }

        public IEnumerable<PersonViewModel> getPersonList()
        {
            return personStore
                .Select(x => new PersonViewModel { 
                    FirstName = x.FirstName,
                    LastName = x.LastName
                });
        }

        public void save(PersonViewModel person)
        {
            try
            {
                using (var db = new EventRegisterContext())
                {
                    db.Persons.Add(new Person
                    {
                        FirstName = "Fnamesl",
                        LastName = "Lasderge",
                        MiddleInitial = "M",
                        PhoneNumber = "123-456-7890",
                        AgeGroup = "2",
                        ID = "1"
                    });
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
            personStore.Add(new Person { 
                FirstName = person.FirstName,
                LastName = person.LastName
            });
        }
    }
}