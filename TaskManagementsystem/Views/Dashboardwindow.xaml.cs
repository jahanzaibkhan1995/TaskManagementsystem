using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TaskManagementsystem.ViewModels;

namespace TaskManagementsystem.Views
{
    /// <summary>
    /// Interaction logic for Dashboardwindow.xaml
    /// </summary>
    public partial class Dashboardwindow : Window
    {
        public string user { get; set; }
        public Dashboardwindow()
        {
            InitializeComponent();
            
        }
    }
}
