using HomeTaskOrganizer.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeTaskOrganizer.Repositories
{
    public class SQLHomeTaskRepository : IHomeTaskRepository
    {
        private readonly ApplicationDbContext _context;

        public SQLHomeTaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HomeTask>> GetAllTasksAsync()
        {
            return await _context.HomeTasks.ToListAsync();
        }

        public async Task<HomeTask> GetTaskByIdAsync(int taskId)
        {
            return await _context.HomeTasks.FindAsync(taskId);
        }

        public async Task AddTaskAsync(HomeTask task)
        {
            _context.HomeTasks.Add(task);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTaskAsync(HomeTask updatedTask)
        {
            _context.Entry(updatedTask).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int taskId)
        {
            var taskToDelete = await _context.HomeTasks.FindAsync(taskId);
            if (taskToDelete != null)
            {
                _context.HomeTasks.Remove(taskToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}
