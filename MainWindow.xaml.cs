using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Habit_Binder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Habit> _habits = new List<Habit>();
        public void CreateNewHabit()
        {
            CreateHabitWindow createHabitWindow = new CreateHabitWindow();
            createHabitWindow.Owner = this;
            createHabitWindow.Show();
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonCreateHabit_Click(object sender, RoutedEventArgs e)
        {
            CreateNewHabit();
            //var CreateGoodHabitWindow = new CreateGoodHabitWindow();
            //CreateGoodHabitWindow.Owner = this;
            //CreateGoodHabitWindow.Show();
        }

        private void ButtonDisplayAll_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDisplaySingle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDisplayTracker_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRecordComplete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
