using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EventRegister.Data;

namespace EventRegister
{
    public class EventRegisterService
    {
        //static List<Person> personStore;

        //static EventRegisterService()
        //{
        //    personStore = new List<Person> {
        //        new Person{
        //            FirstName = "Kolpan",
        //            LastName = "Lopertkety",
        //            MiddleInitial = "B",
        //            PhoneNumber = "458-698-756",
        //            AgeGroup = "2"
        //        },
        //        new Person{
        //            FirstName = "Polod",
        //            LastName = "Moerlokusez",
        //            MiddleInitial = "F",
        //            PhoneNumber = "254-657-458",
        //            AgeGroup = "2"
        //        }
        //    };
        //}

        public List<PersonViewModel> getPersonList()
        {
            try
            {
                using (var db = new EventRegisterContext())
                {
                    return (from p in db.Persons
                            select (new PersonViewModel()
                            {
                                FirstName = p.FirstName,
                                LastName = p.LastName
                            })).ToList<PersonViewModel>();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void save(PersonViewModel person)
        {
            try
            {
                //TODO: check saving

                //int newID = 3;

                using (var db = new EventRegisterContext())
                {
                    // newID = db.Persons.Count() + 1;

                    var p = new Person() {
                        FirstName = person.FirstName,
                        LastName = person.LastName,
                        MiddleInitial = "M",
                        PhoneNumber = "123-456-7890",
                        AgeGroup = "2",
                        ID = 3                    
                    };

                    db.Persons.Add(p);
                    //db.Persons.Add(new Person
                    //{
                    //    FirstName = person.FirstName,
                    //    LastName = person.LastName,
                    //    MiddleInitial = "M",
                    //    PhoneNumber = "123-456-7890",
                    //    AgeGroup = "2",
                    //    ID = newID
                    //});
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}