using HomeTaskOrganizer.Models;
using HomeTaskOrganizer.Repositories;

namespace HomeTaskOrganizer.Services
{
    public class PersonService(IPersonRepository personRepository)
    {
        private readonly IPersonRepository _personRepository = personRepository;

        public Task<IEnumerable<Person>> GetPeopleAsync()
        {
            return _personRepository.GetPeopleAsync();
        }
        public Task<Person> GetPersonByIdAsync(int personId)
        {
            return _personRepository.GetPersonByIdAsync(personId);
        }
        public Task AddPersonAsync(Person person)
        {
            return _personRepository.AddPersonAsync(person);
        }
        public Task UpdatePersonAsync(Person updatedPerson)
        {
            return _personRepository.UpdatePersonAsync(updatedPerson);
        }
        public Task DeletePersonAsync(int personId)
        {
            return _personRepository.DeletePersonAsync(personId);
        }
    }
}
