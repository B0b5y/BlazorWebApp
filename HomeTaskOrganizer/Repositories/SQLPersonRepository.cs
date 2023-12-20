using HomeTaskOrganizer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HomeTaskOrganizer.Repositories
{
    public class SQLPersonRepository : IPersonRepository
    {
        private readonly ApplicationDbContext _context;

        public SQLPersonRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddPersonAsync(Person person)
        {
            try
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

        public async Task DeletePersonAsync(int personId)
        {
            try
            {
                var personToDelete = await _context.People.FindAsync(personId);
                if (personToDelete != null)
                {
                    _context.People.Remove(personToDelete);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error when deleting person: " + ex.Message);
                throw;
            }
        }

        public async Task<IEnumerable<Person>> GetPeopleAsync()
        {
            return await _context.People.ToListAsync();
        }

        public async Task<Person> GetPersonByIdAsync(int personId)
        {
            return await _context.People.FindAsync(personId);
        }

        public async Task UpdatePersonAsync(Person updatedPerson)
        {
            _context.Entry(updatedPerson).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
