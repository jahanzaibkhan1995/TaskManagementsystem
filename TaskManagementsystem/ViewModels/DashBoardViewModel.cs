using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TaskManagementSystem.Repositories;

namespace TaskManagementsystem.ViewModels
{
    public class DashboardViewModel : INotifyPropertyChanged
    {
        private User _user;
        private TaskRepository _taskRepo;

        public ObservableCollection<TaskItem> Tasks { get; set; }
        public string NewTaskTitle { get; set; }

        public DashboardViewModel(User user)
        {
            _user = user;
            _taskRepo = new TaskRepository();
            Tasks = new ObservableCollection<TaskItem>(_taskRepo.GetTasksByUser(user.Id));
        }

        public ICommand AddTaskCommand => new RelayCommand(AddTask);

        private void AddTask()
        {
            var newTask = new TaskItem
            {
                Title = NewTaskTitle,
                UserId = _user.Id,
                Status = "Pending",
                CreatedAt = DateTime.Now
            };
            _taskRepo.AddTask(newTask);
            Tasks.Add(newTask);  // Add task to the ObservableCollection
            NewTaskTitle = string.Empty;  // Clear input field
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}