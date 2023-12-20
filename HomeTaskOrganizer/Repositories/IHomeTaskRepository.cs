using HomeTaskOrganizer.Models;

namespace HomeTaskOrganizer.Repositories
{
    public interface IHomeTaskRepository
    {
        Task<IEnumerable<HomeTask>> GetAllTasksAsync();
        Task<HomeTask> GetTaskByIdAsync(int taskId);
        Task AddTaskAsync(HomeTask task);
        Task UpdateTaskAsync(HomeTask updatedTask);
        Task DeleteTaskAsync(int taskId);
    }
}
