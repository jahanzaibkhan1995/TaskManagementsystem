using System.Collections.Generic;
using System.Linq;
using TaskManagementSystem.Data;

namespace TaskManagementSystem.Repositories
{
    public class TaskRepository
    {
        private readonly AppDbContext _context;

        public TaskRepository()
        {
            _context = new AppDbContext();
        }

        // Add a new task
        public void AddTask(TaskItem task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
        }

        // Get tasks assigned to a specific user
        public List<TaskItem> GetTasksByUser(int userId)
        {
            return _context.Tasks.Where(t => t.UserId == userId).ToList();
        }

        // Update task status
        public void MarkTaskAsCompleted(int taskId)
        {
            var task = _context.Tasks.Find(taskId);
            if (task != null)
            {
                task.IsCompleted = true;
                _context.SaveChanges();
            }
        }
    }
}

