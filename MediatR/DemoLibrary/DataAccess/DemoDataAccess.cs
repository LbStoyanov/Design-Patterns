using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Petrankin", LastName = "Ginkov" });
            people.Add(new PersonModel { Id = 2, FirstName = "4i4o", LastName = "Koleda" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel personalModel = new() { FirstName = firstName, LastName = lastName };
            personalModel.Id = people.Max(x => x.Id) + 1;
            people.Add(personalModel);
            return personalModel;
        }
    }
}
