using HomeTaskOrganizer.Models;
using HomeTaskOrganizer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskOrganizer.Services
{
    public class HomeTaskService(IHomeTaskRepository homeTaskRepository)
    {
        
        private readonly IHomeTaskRepository _homeTaskRepository = homeTaskRepository;


        public async Task<IEnumerable<HomeTask>> GetAllTasksAsync()
        {
            return await _homeTaskRepository.GetAllTasksAsync();
        }

        public async Task<HomeTask> GetTaskByIdAsync(int taskId)
        {
            return await _homeTaskRepository.GetTaskByIdAsync(taskId);
        }

        public async Task AddTaskAsync(HomeTask task)
        {
           await _homeTaskRepository.AddTaskAsync(task);
        }

        public async Task UpdateTaskAsync(HomeTask updatedTask)
        {
           await _homeTaskRepository.UpdateTaskAsync(updatedTask);
        }

        public async Task DeleteTaskAsync(int taskId)
        {
          await _homeTaskRepository.DeleteTaskAsync(taskId);
        }
    }
    
}
