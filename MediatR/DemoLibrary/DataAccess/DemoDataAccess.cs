using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess
    {
        private List<PersonalModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonalModel { Id = 1, FirstName = "Petrankin", LastName = "Ginkov" });
            people.Add(new PersonalModel { Id = 1, FirstName = "4i4o", LastName = "Koleda" });
        }

        public List<PersonalModel> GetPeople()
        {
            return people;
        }

        public PersonalModel InsertPerson(string firstName, string lastName)
        {
            PersonalModel personalModel = new() { FirstName = firstName, LastName = lastName};
            personalModel.Id = people.Max(x => x.Id) + 1;
            people.Add(personalModel);
            return personalModel;
        }
    }
}
