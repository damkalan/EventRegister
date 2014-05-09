using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventRegister
{
    public class EventRegisterService
    {
        public List<PersonViewModel> getPersonList()
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
        }
    }
}