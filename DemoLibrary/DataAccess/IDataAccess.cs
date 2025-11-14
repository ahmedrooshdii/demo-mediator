using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<PersonModel> GetAllPeople();
        PersonModel GetPersonById(int id);
        PersonModel Insert(string firstName, string lastName);
    }
}