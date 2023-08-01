using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Habit_Binder
{
    /// <summary>
    /// Interaction logic for CreateHabitWindow.xaml
    /// </summary>
    public partial class CreateHabitWindow : Window
    {
        public Habit habit;
        public CreateHabitWindow()
        {
            InitializeComponent();
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            if (txtName == null ^ txtIdentityDescription == null ^ txtIdentityDescriptor == null ^ cmbHabitType.SelectedItem == cmbitemDefault)
            {
                txtNotCompleteFlag.Visibility = Visibility.Visible;
            }
            else
            {
                string habitName = txtName.Text;
                string identityDescription = txtIdentityDescription.Text;
                string identityDescriptor = txtIdentityDescriptor.Text;
                Identity identity = new Identity(identityDescriptor, identityDescription);
                if (cmbHabitType.SelectedItem == cmbitemGoodHabit)
                {
                    habit = new GoodHabit(habitName, identity);
                    CreateGoodHabitWindow createGoodHabitWindow = new CreateGoodHabitWindow();
                    createGoodHabitWindow.Owner = this;
                    createGoodHabitWindow.Show();
                }
                else if (cmbHabitType.SelectedItem == cmbitemBadHabit)
                {
                    habit = new BadHabit(habitName, identity);
                }
            }
        }
    }
}
