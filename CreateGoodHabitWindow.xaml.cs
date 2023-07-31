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

namespace Habit_Binder
{
    /// <summary>
    /// Interaction logic for CreateGoodHabitWindow.xaml
    /// </summary>
    public partial class CreateGoodHabitWindow : Window
    {
        public CreateGoodHabitWindow()
        {
            InitializeComponent();
        }

        private void txtMakeItObvious_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMakeItAttractive_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMakeItEasy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtMakeItSatisfying_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ButtonDone_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
