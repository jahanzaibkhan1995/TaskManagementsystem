using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using TaskManagementsystem.Repositories;
using TaskManagementsystem.Views;

namespace TaskManagementsystem.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _email;
        private string _password;
        private UserRepository _userRepo;

        public LoginViewModel()
        {
            _userRepo = new UserRepository();
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public ICommand LoginCommand => new RelayCommand(Login);

        private void Login()
        {
            var user = _userRepo.Authenticate(Email, Password);
            if (user != null)
            {
                // Notify successful login
                MessageBox.Show("Login successful!");
                var dashboardViewModel = new DashboardViewModel(user);
                var dashboard = new Dashboardwindow { DataContext = dashboardViewModel };
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid credentials!");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
