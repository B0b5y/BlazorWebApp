using HomeTaskOrganizer.Models;

namespace HomeTaskOrganizer.Repositories
{
    public interface IPersonRepository
    {
        Task<IEnumerable<Person>> GetPeopleAsync(); // Pobierz wszystkie osoby
        Task<Person> GetPersonByIdAsync(int personId); // Pobierz osobę po identyfikatorze
        Task AddPersonAsync(Person person); // Dodaj nową osobę
        Task UpdatePersonAsync(Person updatedPerson); // Aktualizuj istniejącą osobę
        Task DeletePersonAsync(int personId); // Usuń osobę
    }
}
