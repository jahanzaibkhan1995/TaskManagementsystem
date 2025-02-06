using System.Windows;
using System.Windows.Controls;
using TaskManagementsystem.ViewModels;


namespace TaskManagementsystem.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = new LoginViewModel();
        }
      
    }
}
