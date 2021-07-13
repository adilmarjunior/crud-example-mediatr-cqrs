using DemoLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> people = new List<PersonModel>();

        public DemoDataAccess()
        {
            people.Add(new PersonModel { Id = 1, FirstName = "Linus", LastName = "Tovalds" });
            people.Add(new PersonModel { Id = 2, FirstName = "Bob", LastName = "Smith" });
        }

        public List<PersonModel> GetPeople()
        {
            return people;
        }

        public PersonModel GetPersonById(int id)
        {
            return people.Find(p => p.Id == id);
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel { FirstName = firstName, LastName = lastName };
            p.Id = people.Max(x => x.Id) + 1;
            people.Add(p);
            return p;
        }

    }
}
