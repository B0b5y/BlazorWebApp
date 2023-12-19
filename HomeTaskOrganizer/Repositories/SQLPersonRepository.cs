using HomeTaskOrganizer.Models;
using System.Data.SqlClient;


namespace HomeTaskOrganizer.Repositories
{
    public class SQLPersonRepository : IPersonRepository
    {
        private readonly string _connectionString;

        public SQLPersonRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Metody GetPeopleAsync, GetPersonByIdAsync, UpdatePersonAsync, DeletePersonAsync również muszą być zaimplementowane

        public async Task AddPersonAsync(Person person)
        {
            using var connection = new SqlConnection(_connectionString);
            await connection.OpenAsync();

            var sql = "INSERT INTO People (Name, Email) VALUES (@Name, @Email)";
            using var command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@Name", person.Name);
            command.Parameters.AddWithValue("@Email", person.Email);

            await command.ExecuteNonQueryAsync();
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
