using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
            personStore.Add(new Person { 
                FirstName = person.FirstName,
                LastName = person.LastName
            });
        }
    }
}