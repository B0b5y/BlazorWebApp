using HomeTaskOrganizer.Models;
using System.Data.SqlClient;


namespace HomeTaskOrganizer.Repositories
{
    public class SQLPersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public SQLPersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Metody GetPeopleAsync, GetPersonByIdAsync, UpdatePersonAsync, DeletePersonAsync również muszą być zaimplementowane

        public async Task AddPersonAsync(Person person)
        { try
            {
                _context.People.Add(person);
                await _context.SaveChangesAsync();
 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when adding...");
                throw;
            }
            }
        Task IPersonRepository.DeletePersonAsync(int personId)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Person>> IPersonRepository.GetPeopleAsync()
        {
            throw new NotImplementedException();
        }

        Task<Person> IPersonRepository.GetPersonByIdAsync(int personId)
        {
            throw new NotImplementedException();
        }

        Task IPersonRepository.UpdatePersonAsync(Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
