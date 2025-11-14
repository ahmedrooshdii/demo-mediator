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
        private List<PersonModel> People = new();
        public DemoDataAccess()
        {
            People.Add(new PersonModel { Id = 1, FirstName = "John", LastName = "Doe" });
            People.Add(new PersonModel { Id = 2, FirstName = "Jane", LastName = "Smith" });
        }

        public List<PersonModel> GetAllPeople()
        {
            return People;
        }

        public PersonModel GetPersonById(int id)
        {
            return People.FirstOrDefault(p => p.Id == id);
        }

        public PersonModel Insert(string firstName, string lastName)
        {
            int newId = People.Count > 0 ? People.Max(p => p.Id) + 1 : 1;
            PersonModel newPerson = new() { Id = newId, FirstName = firstName, LastName = lastName };
            People.Add(newPerson);
            return newPerson;
        }
    }
}
